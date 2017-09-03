// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Email.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;

using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    /// <summary>
    /// The email.
    /// </summary>
    public class Email
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Email"/> class.
        /// </summary>
        public Email()
        {
            Links = new HashSet<Link>();
        }

        /// <summary>
        /// Gets or sets the archive url.
        /// </summary>
        [JsonProperty("archive_url")]
        public string ArchiveUrl { get; set; }

        /// <summary>
        /// Gets or sets the content type.
        /// </summary>
        [JsonProperty("content_type")]
        public string ContentType { get; set; }

        /// <summary>
        /// Gets or sets the create time.
        /// </summary>
        [JsonProperty("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// Gets or sets the delay.
        /// </summary>
        [JsonProperty("delay")]
        public Delay Delay { get; set; }

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
        /// Gets or sets the position.
        /// </summary>
        [JsonProperty("position")]
        public int Position { get; set; }

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
        /// Gets or sets the send time.
        /// </summary>
        [JsonProperty("send_time")]
        public string SendTime { get; set; }

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
        /// Gets or sets the workflow id.
        /// </summary>
        [JsonProperty("workflow_id")]
        public string WorkflowId { get; set; }
    }
}