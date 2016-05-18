// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Campaign.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    /// <summary>
    /// The campaign.
    /// </summary>
    public class Campaign
    {
        /// <summary>
        /// Gets or sets the archive url.
        /// </summary>
        [JsonProperty("archive_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ArchiveUrl { get; set; }

        /// <summary>
        /// Gets or sets the content type.
        /// </summary>
        [JsonProperty("content_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ContentType { get; set; }

        /// <summary>
        /// Gets or sets the create time.
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// Gets or sets the delivery status.
        /// </summary>
        [JsonProperty("delivery_status", NullValueHandling = NullValueHandling.Ignore)]
        public DeliveryStatus DeliveryStatus { get; set; }

        /// <summary>
        /// Gets or sets the emails sent.
        /// </summary>
        [JsonProperty("emails_sent")]
        public int EmailsSent { get; set; }

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the links.
        /// </summary>
        [JsonProperty("_links", NullValueHandling = NullValueHandling.Ignore)]
        public Link[] Links { get; set; }

        /// <summary>
        /// Gets or sets the recipients.
        /// </summary>
        [JsonProperty("recipients", NullValueHandling = NullValueHandling.Ignore)]
        public Recipient Recipients { get; set; }

        /// <summary>
        /// Gets or sets the send time.
        /// </summary>
        [JsonProperty("send_time", NullValueHandling = NullValueHandling.Ignore)]
        public string SendTime { get; set; }

        /// <summary>
        /// Gets or sets the settings.
        /// </summary>
        [JsonProperty("settings")]
        public Setting Settings { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the tracking.
        /// </summary>
        [JsonProperty("tracking", NullValueHandling = NullValueHandling.Ignore)]
        public Tracking Tracking { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}