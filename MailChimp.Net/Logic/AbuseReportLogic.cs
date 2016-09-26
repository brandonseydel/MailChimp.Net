// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AbuseReportLogic.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using static System.Net.Http.HttpContentExtensions;
using System.Threading.Tasks;

using MailChimp.Net.Core;
using MailChimp.Net.Interfaces;
using MailChimp.Net.Models;
#pragma warning disable 1584,1711,1572,1581,1580

namespace MailChimp.Net.Logic
{
    /// <summary>
    /// The abuse report logic.
    /// </summary>
    public class AbuseReportLogic : BaseLogic, IAbuseReportLogic
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="AbuseReportLogic"/> class.
        /// </summary>
        /// <param name="apiKey">
        /// The api key.
        /// </param>
        public AbuseReportLogic(string apiKey) : base(apiKey)
        {
            _limit = MailChimpConfiguration.DefaultLimit;
        }

        public AbuseReportLogic(string apiKey, int limit) : base(apiKey, limit)
        {
        }

        /// <summary>
        /// The get all async.
        /// </summary>
        /// <param name="listId">
        /// The list Id.
        /// </param>
        /// <param name="request">
        /// The request.
        /// </param>
        /// <exception cref="ArgumentNullException">
        /// The <paramref>
        ///         <name>requestUri</name>
        ///     </paramref>
        ///     was null.
        /// </exception>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        /// <exception cref="UriFormatException">In the .NET for Windows Store apps or the Portable Class Library, catch the base class exception, <see cref="T:System.FormatException" />, instead.<paramref name="uriString" /> is empty.-or- The scheme specified in <paramref name="uriString" /> is not correctly formed. See <see cref="M:System.Uri.CheckSchemeName(System.String)" />.-or- <paramref name="uriString" /> contains too many slashes.-or- The password specified in <paramref name="uriString" /> is not valid.-or- The host name specified in <paramref name="uriString" /> is not valid.-or- The file name specified in <paramref name="uriString" /> is not valid. -or- The user name specified in <paramref name="uriString" /> is not valid.-or- The host or authority name specified in <paramref name="uriString" /> cannot be terminated by backslashes.-or- The port number specified in <paramref name="uriString" /> is not valid or cannot be parsed.-or- The length of <paramref name="uriString" /> exceeds 65519 characters.-or- The length of the scheme specified in <paramref name="uriString" /> exceeds 1023 characters.-or- There is an invalid character sequence in <paramref name="uriString" />.-or- The MS-DOS path specified in <paramref name="uriString" /> must start with c:\\.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Enlarging the value of this instance would exceed <see cref="P:System.Text.StringBuilder.MaxCapacity" />. </exception>
        /// <exception cref="MailChimpException">
        /// Custom Mail Chimp Exception
        /// </exception>
        public async Task<IEnumerable<AbuseReport>> GetAllAsync(string listId, QueryableBaseRequest request = null)
        {
            return (await GetResponseAsync(listId, request).ConfigureAwait(false))?.AbuseReports;
        }


        /// <summary>
        /// The get all async.
        /// </summary>
        /// <param name="listId">
        /// The list Id.
        /// </param>
        /// <param name="request">
        /// The request.
        /// </param>
        /// <exception cref="ArgumentNullException">
        /// The <paramref>
        ///         <name>requestUri</name>
        ///     </paramref>
        ///     was null.
        /// </exception>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        /// <exception cref="UriFormatException">In the .NET for Windows Store apps or the Portable Class Library, catch the base class exception, <see cref="T:System.FormatException" />, instead.<paramref name="uriString" /> is empty.-or- The scheme specified in <paramref name="uriString" /> is not correctly formed. See <see cref="M:System.Uri.CheckSchemeName(System.String)" />.-or- <paramref name="uriString" /> contains too many slashes.-or- The password specified in <paramref name="uriString" /> is not valid.-or- The host name specified in <paramref name="uriString" /> is not valid.-or- The file name specified in <paramref name="uriString" /> is not valid. -or- The user name specified in <paramref name="uriString" /> is not valid.-or- The host or authority name specified in <paramref name="uriString" /> cannot be terminated by backslashes.-or- The port number specified in <paramref name="uriString" /> is not valid or cannot be parsed.-or- The length of <paramref name="uriString" /> exceeds 65519 characters.-or- The length of the scheme specified in <paramref name="uriString" /> exceeds 1023 characters.-or- There is an invalid character sequence in <paramref name="uriString" />.-or- The MS-DOS path specified in <paramref name="uriString" /> must start with c:\\.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Enlarging the value of this instance would exceed <see cref="P:System.Text.StringBuilder.MaxCapacity" />. </exception>
        /// <exception cref="MailChimpException">
        /// Custom Mail Chimp Exception
        /// </exception>
        public async Task<AbuseReportResponse> GetResponseAsync(string listId, QueryableBaseRequest request = null)
        {

            request = new QueryableBaseRequest
            {
                Limit = base._limit
            };

            using (var client = this.CreateMailClient("lists/"))
            {
                var response = await client.GetAsync($"{listId}/abuse-reports{request?.ToQueryString()}").ConfigureAwait(false);
                await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

                var appResponse = await response.Content.ReadAsAsync<AbuseReportResponse>().ConfigureAwait(false);
                return appResponse;
            }
        }


        /// <summary>
        /// The get async.
        /// </summary>
        /// <param name="listId">
        /// The list Id.
        /// </param>
        /// <param name="reportId">
        /// The report Id.
        /// </param>
        /// <param name="request">
        /// The request.
        /// </param>
        /// <exception cref="ArgumentNullException">
        /// The <paramref>
        ///         <name>requestUri</name>
        ///     </paramref>
        ///     was null.
        /// </exception>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        /// <exception cref="UriFormatException">In the .NET for Windows Store apps or the Portable Class Library, catch the base class exception, <see cref="T:System.FormatException" />, instead.<paramref name="uriString" /> is empty.-or- The scheme specified in <paramref name="uriString" /> is not correctly formed. See <see cref="M:System.Uri.CheckSchemeName(System.String)" />.-or- <paramref name="uriString" /> contains too many slashes.-or- The password specified in <paramref name="uriString" /> is not valid.-or- The host name specified in <paramref name="uriString" /> is not valid.-or- The file name specified in <paramref name="uriString" /> is not valid. -or- The user name specified in <paramref name="uriString" /> is not valid.-or- The host or authority name specified in <paramref name="uriString" /> cannot be terminated by backslashes.-or- The port number specified in <paramref name="uriString" /> is not valid or cannot be parsed.-or- The length of <paramref name="uriString" /> exceeds 65519 characters.-or- The length of the scheme specified in <paramref name="uriString" /> exceeds 1023 characters.-or- There is an invalid character sequence in <paramref name="uriString" />.-or- The MS-DOS path specified in <paramref name="uriString" /> must start with c:\\.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Enlarging the value of this instance would exceed <see cref="P:System.Text.StringBuilder.MaxCapacity" />. </exception>
        /// <exception cref="MailChimpException">
        /// Custom Mail Chimp Exception
        /// </exception>
        public async Task<AbuseReport> GetAsync(string listId, string reportId, QueryableBaseRequest request = null)
        {
            using (var client = this.CreateMailClient("lists/"))
            {
                var response = await client.GetAsync($"{listId}/abuse-reports{reportId}{request?.ToQueryString()}").ConfigureAwait(false);
                await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

                return await response.Content.ReadAsAsync<AbuseReport>().ConfigureAwait(false);
            }
        }
    }
}