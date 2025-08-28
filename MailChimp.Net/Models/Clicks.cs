// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Clicks.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System;
using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    /// <summary>
    /// The clicks.
    /// </summary>
    public class Clicks
    {
        /// <summary>
        /// Gets or sets the click rate.
        /// </summary>
        [JsonProperty("click_rate")]
        public double ClickRate { get; set; }

        /// <summary>
        /// Gets or sets the clicks total.
        /// </summary>
        [JsonProperty("clicks_total")]
        public int ClicksTotal { get; set; }

        /// <summary>
        /// Gets or sets the last click.
        /// </summary>
        [JsonProperty("last_click")]
        public DateTime? LastClick { get; set; }

        /// <summary>
        /// Gets or sets the unique clicks.
        /// </summary>
        [JsonProperty("unique_clicks")]
        public int UniqueClicks { get; set; }

        /// <summary>
        /// Gets or sets the unique subscriber clicks.
        /// </summary>
        [JsonProperty("unique_subscriber_clicks")]
        public int UniqueSubscriberClicks { get; set; }
    }
}