// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Automation.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;

using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    /// <summary>
    /// The automation.
    /// </summary>
    public class Automation
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Automation"/> class.
        /// </summary>
        public Automation()
        {
            this.Links = new HashSet<Link>();
        }

        /// <summary>
        /// Gets or sets the create time.
        /// </summary>
        [JsonProperty("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// Gets or sets the emails sent.
        /// </summary>
        [JsonProperty("emails_sent")]
        public int EmailsSent { get; set; }

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the links.
        /// </summary>
        [JsonProperty("_links")]
        public IEnumerable<Link> Links { get; set; }

        /// <summary>
        /// Gets or sets the recipients.
        /// </summary>
        [JsonProperty("recipients")]
        public Recipient Recipients { get; set; }

        /// <summary>
        /// Gets or sets the report summary.
        /// </summary>
        [JsonProperty("report_summary")]
        public ReportSummary ReportSummary { get; set; }

        /// <summary>
        /// Gets or sets the settings.
        /// </summary>
        [JsonProperty("settings")]
        public Setting Settings { get; set; }

        /// <summary>
        /// Gets or sets the start time.
        /// </summary>
        [JsonProperty("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the tracking.
        /// </summary>
        [JsonProperty("tracking")]
        public Tracking Tracking { get; set; }

        /// <summary>
        /// Gets or sets the trigger settings.
        /// </summary>
        [JsonProperty("trigger_settings")]
        public TriggerSettings TriggerSettings { get; set; }
    }
}