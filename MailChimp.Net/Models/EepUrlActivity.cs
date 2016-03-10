// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EepUrlActivity.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;

using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    /// <summary>
    /// The eep url activity.
    /// </summary>
    public class EepUrlActivity
    {
        /// <summary>
        /// Gets or sets the campaign id.
        /// </summary>
        [JsonProperty("campaign_id")]
        public string CampaignId { get; set; }

        /// <summary>
        /// Gets or sets the clicks.
        /// </summary>
        public IEnumerable<EepClick> Clicks { get; set; }

        /// <summary>
        /// Gets or sets the eep url.
        /// </summary>
        public string EepUrl { get; set; }

        /// <summary>
        /// Gets or sets the referrers.
        /// </summary>
        public IEnumerable<Referrer> Referrers { get; set; }

        /// <summary>
        /// Gets or sets the total items.
        /// </summary>
        [JsonProperty("total_items")]
        public string TotalItems { get; set; }

        /// <summary>
        /// Gets or sets the twitter.
        /// </summary>
        public Twitter Twitter { get; set; }
    }
}