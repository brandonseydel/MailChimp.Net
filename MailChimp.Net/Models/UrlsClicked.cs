// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UrlsClicked.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    /// <summary>
    /// The url clicked.
    /// </summary>
    public class UrlClicked
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UrlClicked"/> class.
        /// </summary>
        public UrlClicked()
        {
            Links = new HashSet<Link>();
        }

        /// <summary>
        /// Gets or sets the campaign id.
        /// </summary>
        [JsonProperty("campaign_id")]
        public string CampaignId { get; set; }

        /// <summary>
        /// Gets or sets the click percentage.
        /// </summary>
        [JsonProperty("click_percentage")]
        public double ClickPercentage { get; set; }

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the last click.
        /// </summary>
        [JsonProperty("last_click")]
        public DateTime? LastClick { get; set; }

        /// <summary>
        /// Gets or sets the links.
        /// </summary>
        [JsonProperty("_links")]
        public IEnumerable<Link> Links { get; set; }

        /// <summary>
        /// Gets or sets the total clicks.
        /// </summary>
        [JsonProperty("total_clicks")]
        public int TotalClicks { get; set; }

        /// <summary>
        /// Gets or sets the unique click percentage.
        /// </summary>
        [JsonProperty("unique_click_percentage")]
        public double UniqueClickPercentage { get; set; }

        /// <summary>
        /// Gets or sets the unique clicks.
        /// </summary>
        [JsonProperty("unique_clicks")]
        public int UniqueClicks { get; set; }

        /// <summary>
        /// Gets or sets the url.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}