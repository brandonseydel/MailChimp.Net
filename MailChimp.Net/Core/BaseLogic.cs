// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BaseLogic.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
#if HTTP_CLIENT_FACTORY
using Microsoft.Extensions.DependencyInjection;
#endif

#pragma warning disable 1584, 1711, 1572, 1581, 1580

namespace MailChimp.Net.Core
{
    /// <summary>
    /// The base logic.
    /// </summary>
    public abstract class BaseLogic
    {
        internal const int ApiTimeout = 120;

        internal int _limit => _options.Limit;

        internal MailChimpOptions _options;

#if HTTP_CLIENT_FACTORY
        private static ConcurrentDictionary<string, IHttpClientFactory> s_clientFactories = new ConcurrentDictionary<string, IHttpClientFactory>();

        private IHttpClientFactory GetHttpClientFactory()
        {
            // if factory already has the key then let it go
            if(s_clientFactories.TryGetValue(this._options.ApiKey ?? "OAuthMode", out var returnValue))
            {
                return returnValue;
            }

            var serviceCollection = new ServiceCollection();
            serviceCollection.AddHttpClient(this._options.ApiKey ?? "OAuthMode", client =>
            {
                client.BaseAddress = new Uri(GetBaseAddress());
                client.Timeout = TimeSpan.FromSeconds(ApiTimeout);
            })
                .ConfigurePrimaryHttpMessageHandler(handler =>
                new HttpClientHandler()
                {
                    AutomaticDecompression = System.Net.DecompressionMethods.GZip | System.Net.DecompressionMethods.Deflate
                });

            var serviceProvider = serviceCollection.BuildServiceProvider();
            var factory = serviceProvider.GetService<IHttpClientFactory>();
            s_clientFactories.TryAdd(this._options.ApiKey ?? "OAuthMode", factory);
            return factory;
        }

#endif


        protected BaseLogic(MailChimpOptions options)
        {
            _options = options;
        }

        /// <summary>
        /// The create mail client.
        /// </summary>
        /// <param name="resource">
        /// The resource.
        /// </param>
        /// <returns>
        /// The <see cref="HttpClient"/>.
        /// </returns>
        /// <exception cref="ArgumentNullException"><paramref>
        ///         <name>uriString</name>
        ///     </paramref>
        ///     is null. </exception>
        /// <exception cref="UriFormatException">In the .NET for Windows Store apps or the Portable Class Library, catch the base class exception, <see cref="T:System.FormatException" />, instead.<paramref name="uriString" /> is empty.-or- The scheme specified in <paramref name="uriString" /> is not correctly formed. See <see cref="M:System.Uri.CheckSchemeName(System.String)" />.-or- <paramref name="uriString" /> contains too many slashes.-or- The password specified in <paramref name="uriString" /> is not valid.-or- The host name specified in <paramref name="uriString" /> is not valid.-or- The file name specified in <paramref name="uriString" /> is not valid. -or- The user name specified in <paramref name="uriString" /> is not valid.-or- The host or authority name specified in <paramref name="uriString" /> cannot be terminated by backslashes.-or- The port number specified in <paramref name="uriString" /> is not valid or cannot be parsed.-or- The length of <paramref name="uriString" /> exceeds 65519 characters.-or- The length of the scheme specified in <paramref name="uriString" /> exceeds 1023 characters.-or- There is an invalid character sequence in <paramref name="uriString" />.-or- The MS-DOS path specified in <paramref name="uriString" /> must start with c:\\.</exception>
        protected MailChimpHttpClient CreateMailClient(string resource)
        {
#if HTTP_CLIENT_FACTORY
            return FactoryProvidedHttpClient(resource);
#else
            return NewedUpHttpClient(resource);
#endif
        }


#if HTTP_CLIENT_FACTORY
        private MailChimpHttpClient FactoryProvidedHttpClient(string resource)
        {
            var client = GetHttpClientFactory().CreateClient(_options.ApiKey ?? "OAuthMode");
            return new MailChimpHttpClient(client, _options, resource);
        }
#endif


        private MailChimpHttpClient NewedUpHttpClient(string resource)
        {
            var handler = new HttpClientHandler();
            if (handler.SupportsAutomaticDecompression)
            {
                handler.AutomaticDecompression = System.Net.DecompressionMethods.GZip | System.Net.DecompressionMethods.Deflate;
            }
            var client = new HttpClient(handler)
            {
                BaseAddress = new Uri(GetBaseAddress()),
                Timeout = TimeSpan.FromSeconds(ApiTimeout)
            };
            return new MailChimpHttpClient(client, _options, resource);
        }

        private string GetBaseAddress()
        {
            return $"https://{_options.DataCenter}.api.mailchimp.com/3.0/";
        }

        /// <summary>
        /// The hash.
        /// </summary>
        /// <param name="emailAddressOrHash">
        /// The email address.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        /// <exception cref="TargetInvocationException">The algorithm was used with Federal Information Processing Standards (FIPS) mode enabled, but is not FIPS compatible.</exception>
        /// <exception cref="ObjectDisposedException">
        /// The object has already been disposed.
        /// </exception>
        /// <exception cref="ArgumentNullException">
        /// <paramref>
        ///         <name>s</name>
        ///     </paramref>
        ///     is null.
        /// </exception>
        /// <exception cref="EncoderFallbackException">
        /// A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-<see cref="P:System.Text.Encoding.EncoderFallback"/> is set to <see cref="T:System.Text.EncoderExceptionFallback"/>.
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Enlarging the value of this instance would exceed <see cref="P:System.Text.StringBuilder.MaxCapacity"/>.
        /// </exception>
        /// <exception cref="FormatException">
        /// <paramref>
        ///         <name>format</name>
        ///     </paramref>
        /// includes an unsupported specifier. Supported format specifiers are listed in the Remarks section.
        /// </exception>
        public string Hash(string emailAddressOrHash)
        {
            if (!emailAddressOrHash.Contains("@")) { return emailAddressOrHash; } //this is hashed already

            using (var md5 = MD5.Create()) return md5.GetHash(emailAddressOrHash.ToLower());
        }
    }
}
