using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    internal class CampaignDefaults
    {

        [JsonProperty("from_name")]
        public string FromName { get; set; }

        [JsonProperty("from_email")]
        public string FromEmail { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }
    }
}