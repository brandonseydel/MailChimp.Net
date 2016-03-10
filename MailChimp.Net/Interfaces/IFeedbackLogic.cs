// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IFeedbackLogic.cs" company="Brandon Seydel">
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
    /// The FeedbackLogic interface.
    /// </summary>
    public interface IFeedbackLogic
    {
        /// <summary>
        /// The add or update async.
        /// </summary>
        /// <param name="campaignId">
        /// The campaign id.
        /// </param>
        /// <param name="feedback">
        /// The feedback.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<Feedback> AddOrUpdateAsync(string campaignId, Feedback feedback);

        /// <summary>
        /// The delete async.
        /// </summary>
        /// <param name="campaignId">
        /// The campaign id.
        /// </param>
        /// <param name="feedbackId">
        /// The feedback id.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task DeleteAsync(string campaignId, string feedbackId);

        /// <summary>
        /// The get all async.
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
        Task<IEnumerable<Feedback>> GetAllAsync(string campaignId, FeedbackRequest request = null);

        /// <summary>
        /// The get async.
        /// </summary>
        /// <param name="campaignId">
        /// The campaign id.
        /// </param>
        /// <param name="feedbackId">
        /// The feedback id.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<Feedback> GetAsync(string campaignId, string feedbackId);
    }
}