// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Conversation.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    /// <summary>
    /// The conversation.
    /// </summary>
    public class Conversation
    {
        /// <summary>
        /// Gets or sets the campaign id.
        /// </summary>
        [JsonProperty("campaign_id")]
        public string CampaignId { get; set; }

        /// <summary>
        /// Gets or sets the from email.
        /// </summary>
        [JsonProperty("from_email")]
        public string FromEmail { get; set; }

        /// <summary>
        /// Gets or sets the from label.
        /// </summary>
        [JsonProperty("from_label")]
        public string FromLabel { get; set; }

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the last message.
        /// </summary>
        [JsonProperty("last_message")]
        public Message LastMessage { get; set; }

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
        /// Gets or sets the message count.
        /// </summary>
        [JsonProperty("message_count")]
        public int MessageCount { get; set; }

        /// <summary>
        /// Gets or sets the subject.
        /// </summary>
        [JsonProperty("subject")]
        public string Subject { get; set; }

        /// <summary>
        /// Gets or sets the unread messages.
        /// </summary>
        [JsonProperty("unread_messages")]
        public int UnreadMessages { get; set; }
    }
}