// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EepUrlActivity.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Diagnostics;
using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    /// <summary>
    /// The eep url activity.
    /// </summary>
    public class EepUrlActivity : Base
    {
        /// <summary>
        /// Gets or sets the campaign id.
        /// </summary>
        [JsonProperty("campaign_id")]
        public string CampaignId { get; set; }

        /// <summary>
        /// Gets or sets the clicks.
        /// </summary>
        [JsonProperty("clicks")]
        public IEnumerable<EepClick> Clicks { get; set; }

        /// <summary>
        /// Gets or sets the eep url.
        /// </summary>
        [JsonProperty("eepurl")]
        public string EepUrl { get; set; }

        /// <summary>
        /// Gets or sets the referrers.
        /// </summary>
        [JsonProperty("referrers")]
        public IEnumerable<Referrer> Referrers { get; set; }

        /// <summary>
        /// Gets or sets the total items.
        /// </summary>
        [JsonProperty("total_items")]
        public string TotalItems { get; set; }

        /// <summary>
        /// Gets or sets the twitter.
        /// </summary>
        [JsonProperty("twitter")]
        public Twitter Twitter { get; set; }

        internal override DisplayBuilder GetDebuggerDisplayBuilder(DisplayBuilder Builder) {
            return base.GetDebuggerDisplayBuilder(Builder)
                .Data.Add(EepUrl)
                ;
        }
    }
}