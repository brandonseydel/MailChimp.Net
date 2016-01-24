using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    public class AbuseReport
    {

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("campaign_id")]
        public string CampaignId { get; set; }

        [JsonProperty("list_id")]
        public string ListId { get; set; }

        [JsonProperty("email_id")]
        public string EmailId { get; set; }

        [JsonProperty("email_address")]
        public string EmailAddress { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }
    }
}