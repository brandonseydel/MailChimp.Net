// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IContentLogic.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Threading.Tasks;

using MailChimp.Net.Core;
using MailChimp.Net.Models;

namespace MailChimp.Net.Interfaces
{
    /// <summary>
    /// The ContentLogic interface.
    /// </summary>
    public interface IContentLogic
    {
        /// <summary>
        /// The add or update async.
        /// </summary>
        /// <param name="campaignId">
        /// The campaign id.
        /// </param>
        /// <param name="request">
        /// The request.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<Content> AddOrUpdateAsync(string campaignId, ContentRequest request);

        /// <summary>
        /// The get async.
        /// </summary>
        /// <param name="campaignId">
        /// The campaign id.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<Content> GetAsync(string campaignId);
    }
}