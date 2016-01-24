using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    public class History
    {
        [JsonProperty("list_id")]
        public string ListId { get; set; }

        [JsonProperty("month")]
        public string Month { get; set; }

        [JsonProperty("existing")]
        public int Existing { get; set; }

        [JsonProperty("imports")]
        public int Imports { get; set; }

        [JsonProperty("optins")]
        public int Optins { get; set; }

        [JsonProperty("_links")]
        public Link[] Links { get; set; }
    }
}