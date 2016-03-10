// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ReportSummary.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    /// <summary>
    /// The report summary.
    /// </summary>
    public class ReportSummary
    {
        /// <summary>
        /// Gets or sets the click rate.
        /// </summary>
        [JsonProperty("click_rate")]
        public int ClickRate { get; set; }

        /// <summary>
        /// Gets or sets the clicks.
        /// </summary>
        [JsonProperty("clicks")]
        public int Clicks { get; set; }

        /// <summary>
        /// Gets or sets the open rate.
        /// </summary>
        [JsonProperty("open_rate")]
        public int OpenRate { get; set; }

        /// <summary>
        /// Gets or sets the opens.
        /// </summary>
        [JsonProperty("opens")]
        public int Opens { get; set; }

        /// <summary>
        /// Gets or sets the subscriber clicks.
        /// </summary>
        [JsonProperty("subscriber_clicks")]
        public int SubscriberClicks { get; set; }

        /// <summary>
        /// Gets or sets the unique opens.
        /// </summary>
        [JsonProperty("unique_opens")]
        public int UniqueOpens { get; set; }
    }
}