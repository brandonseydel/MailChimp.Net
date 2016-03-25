// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IAbuseReportLogic.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Threading.Tasks;

using MailChimp.Net.Core;
using MailChimp.Net.Models;

namespace MailChimp.Net.Interfaces
{
    using System;

    /// <summary>
    /// The AbuseReportLogic interface.
    /// </summary>
    public interface IAbuseReportLogic
    {
        /// <summary>
        /// Gets all the abuse reports from Mail Chimp
        /// </summary>
        /// <param name="listId">
        /// The list id.
        /// </param>
        /// <param name="request">
        /// The request.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<IEnumerable<AbuseReport>> GetAllAsync(string listId, QueryableBaseRequest request);

        /// <summary>
        /// The get async.
        /// </summary>
        /// <param name="listId">
        /// The list id.
        /// </param>
        /// <param name="reportId">
        /// The report id.
        /// </param>
        /// <param name="request">
        /// The request.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<AbuseReport> GetAsync(string listId, string reportId, QueryableBaseRequest request);

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
        Task<AbuseReportResponse> GetResponseAsync(string listId, QueryableBaseRequest request);
    }
}