// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ICampaignLogic.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using MailChimp.Net.Core;
using MailChimp.Net.Models;

namespace MailChimp.Net.Interfaces
{
    /// <summary>
    /// The CampaignLogic interface.
    /// </summary>
    public interface ICampaignLogic
    {
        /// <summary>
        /// The add or update async.
        /// </summary>
        /// <param name="campaignId">
        /// The campaign id.
        /// </param>
        /// <param name="campaign">
        /// The campaign.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        [Obsolete]
        Task<Campaign> AddOrUpdateAsync(string campaignId, Campaign campaign);

        /// <summary>
        /// The add or update async.
        /// </summary>
        /// <param name="campaign">
        /// The campaign.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<Campaign> AddOrUpdateAsync(Campaign campaign);


        /// <summary>
        /// The cancel async.
        /// </summary>
        /// <param name="campaignId">
        /// The campaign id.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task CancelAsync(string campaignId);

        /// <summary>
        /// The delete async.
        /// </summary>
        /// <param name="campaignId">
        /// The campaign id.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task DeleteAsync(string campaignId);

        /// <summary>
        /// The get all.
        /// </summary>
        /// <param name="request">
        /// The request.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<IEnumerable<Campaign>> GetAll(CampaignRequest request = null);

        /// <summary>
        /// The get async.
        /// </summary>
        /// <param name="id">
        /// The id.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<Campaign> GetAsync(string id);

        /// <summary>
        /// The send async.
        /// </summary>
        /// <param name="campaignId">
        /// The campaign id.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task SendAsync(string campaignId);
    }
}