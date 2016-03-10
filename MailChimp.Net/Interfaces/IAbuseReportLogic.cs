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
    }
}