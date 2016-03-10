// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SentTo.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    /// <summary>
    /// The sent to.
    /// </summary>
    public class SentTo
    {
        /// <summary>
        /// Gets or sets the absplit group.
        /// </summary>
        [JsonProperty("absplit_group")]
        public string AbsplitGroup { get; set; }

        /// <summary>
        /// Gets or sets the campaign id.
        /// </summary>
        [JsonProperty("campaign_id")]
        public string CampaignId { get; set; }

        /// <summary>
        /// Gets or sets the email address.
        /// </summary>
        [JsonProperty("email_address")]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Gets or sets the email id.
        /// </summary>
        [JsonProperty("email_id")]
        public string EmailId { get; set; }

        /// <summary>
        /// Gets or sets the gmt offset.
        /// </summary>
        [JsonProperty("gmt_offset")]
        public int GmtOffset { get; set; }

        /// <summary>
        /// Gets or sets the last open.
        /// </summary>
        [JsonProperty("last_open")]
        public string LastOpen { get; set; }

        /// <summary>
        /// Gets or sets the links.
        /// </summary>
        [JsonProperty("_links")]
        public Link[] Links { get; set; }

        /// <summary>
        /// Gets or sets the list id.
        /// </summary>
        [JsonProperty("list_id")]
        public string ListId { get; set; }

        /// <summary>
        /// Gets or sets the open count.
        /// </summary>
        [JsonProperty("open_count")]
        public int OpenCount { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}