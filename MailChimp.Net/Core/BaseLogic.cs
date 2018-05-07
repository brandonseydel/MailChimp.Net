// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BaseLogic.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Net.Http;
using System.Security.Cryptography;
#pragma warning disable 1584, 1711, 1572, 1581, 1580

namespace MailChimp.Net.Core
{
    /// <summary>
    /// The base logic.
    /// </summary>
    public abstract class BaseLogic
    {
        internal int _limit => _options.Limit;

        internal MailChimpOptions _options;

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
        protected HttpClient CreateMailClient(string resource)
        {
            var handler = new HttpClientHandler();
            if (handler.SupportsAutomaticDecompression)
            {
                handler.AutomaticDecompression = System.Net.DecompressionMethods.GZip | System.Net.DecompressionMethods.Deflate;
            }

            var client = new HttpClient(handler)
                             {
                                 BaseAddress =
                                     new Uri($"https://{_options.DataCenter}.api.mailchimp.com/3.0/{resource}")
                             };
            client.DefaultRequestHeaders.Add("Authorization", _options.AuthHeader);
            client.DefaultRequestHeaders.Add("user-agent", "Bewise_DanDomain-WebApp");
            return client;
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