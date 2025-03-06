// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IndustryStats.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    /// <summary>
    /// The industry stats.
    /// </summary>
    public class IndustryStats
    {
        /// <summary>
        /// Gets or sets the abuse rate.
        /// </summary>
        [JsonProperty("abuse_rate")]
        public double AbuseRate { get; set; }

        /// <summary>
        /// Gets or sets the bounce rate.
        /// </summary>
        [JsonProperty("bounce_rate")]
        public double BounceRate { get; set; }

        /// <summary>
        /// Gets or sets the click rate.
        /// </summary>
        [JsonProperty("click_rate")]
        public double ClickRate { get; set; }

        /// <summary>
        /// Gets or sets the open rate.
        /// </summary>
        [JsonProperty("open_rate")]
        public double OpenRate { get; set; }

        /// <summary>
        /// Gets or sets the result.
        /// </summary>
        [JsonProperty("type")]
        public string Result { get; set; }

        /// <summary>
        /// Gets or sets the unopen rate.
        /// </summary>
        [JsonProperty("unopen_rate")]
        public double UnopenRate { get; set; }

        /// <summary>
        /// Gets or sets the unsub rate.
        /// </summary>
        [JsonProperty("unsub_rate")]
        public double UnsubRate { get; set; }
    }
}