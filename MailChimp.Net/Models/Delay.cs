using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    public class Delay
    {

        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("direction")]
        public string Direction { get; set; }

        [JsonProperty("action")]
        public string Action { get; set; }
    }
}