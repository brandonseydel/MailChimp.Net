using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    public class Conversation
    {

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("message_count")]
        public int MessageCount { get; set; }

        [JsonProperty("campaign_id")]
        public string CampaignId { get; set; }

        [JsonProperty("list_id")]
        public string ListId { get; set; }

        [JsonProperty("unread_messages")]
        public int UnreadMessages { get; set; }

        [JsonProperty("from_label")]
        public string FromLabel { get; set; }

        [JsonProperty("from_email")]
        public string FromEmail { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("last_message")]
        public Message LastMessage { get; set; }

        [JsonProperty("_links")]
        public Link[] Links { get; set; }
    }
}
