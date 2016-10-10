// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Report.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;

using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    /// <summary>
    /// The report.
    /// </summary>
    public class Report
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Report"/> class.
        /// </summary>
        public Report()
        {
            this.Timeseries = new HashSet<Timesery>();
            this.Links = new HashSet<Link>();
        }

        /// <summary>
        /// Gets or sets the abuse reports.
        /// </summary>
        [JsonProperty("abuse_reports")]
        public int AbuseReports { get; set; }

        /// <summary>
        /// Gets or sets the bounces.
        /// </summary>
        [JsonProperty("bounces")]
        public Bounces Bounces { get; set; }

        /// <summary>
        /// Gets or sets the campaign title.
        /// </summary>
        [JsonProperty("campaign_title")]
        public string CampaignTitle { get; set; }

        /// <summary>
        /// Gets or sets the clicks.
        /// </summary>
        [JsonProperty("clicks")]
        public Clicks Clicks { get; set; }

        /// <summary>
        /// Gets or sets the delivery status.
        /// </summary>
        [JsonProperty("delivery_status")]
        public DeliveryStatus DeliveryStatus { get; set; }

        /// <summary>
        /// Gets or sets the emails sent.
        /// </summary>
        [JsonProperty("emails_sent")]
        public int EmailsSent { get; set; }

        /// <summary>
        /// Gets or sets the facebook likes.
        /// </summary>
        [JsonProperty("facebook_likes")]
        public FacebookLikes FacebookLikes { get; set; }

        /// <summary>
        /// Gets or sets the forwards.
        /// </summary>
        [JsonProperty("forwards")]
        public Forwards Forwards { get; set; }

        /// <summary>
        /// Gets or sets the subject line.
        /// </summary>
        [JsonProperty("subject_line")]
        public string SubjectLine { get; set; }

        /// <summary>
        /// Gets or sets the list name.
        /// </summary>
        [JsonProperty("list_name")]
        public string ListName { get; set; }

        /// <summary>
        /// Gets or sets the list id.
        /// </summary>
        [JsonProperty("list_id")]
        public string ListId { get; set; }

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the industry stats.
        /// </summary>
        [JsonProperty("industry_stats")]
        public IndustryStats IndustryStats { get; set; }

        /// <summary>
        /// Gets or sets the links.
        /// </summary>
        [JsonProperty("_links")]
        public IEnumerable<Link> Links { get; set; }

        /// <summary>
        /// Gets or sets the list stats.
        /// </summary>
        [JsonProperty("list_stats")]
        public ListStats ListStats { get; set; }

        /// <summary>
        /// Gets or sets the opens.
        /// </summary>
        [JsonProperty("opens")]
        public Opens Opens { get; set; }

        /// <summary>
        /// Gets or sets the send time.
        /// </summary>
        [JsonProperty("send_time")]
        public string SendTime { get; set; }

        /// <summary>
        /// Gets or sets the share report.
        /// </summary>
        [JsonProperty("share_report")]
        public ShareReport ShareReport { get; set; }

        /// <summary>
        /// Gets or sets the timeseries.
        /// </summary>
        [JsonProperty("timeseries")]
        public IEnumerable<Timesery> Timeseries { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the unsubscribed.
        /// </summary>
        [JsonProperty("unsubscribed")]
        public int Unsubscribed { get; set; }
    }
}