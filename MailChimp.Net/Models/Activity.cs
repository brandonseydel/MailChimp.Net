using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    public class Activity
    {
        [JsonProperty("action")]
        public string Action { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("campaign_id")]
        public string CampaignId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }
}