using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    internal class IndustryStats
    {

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("open_rate")]
        public double OpenRate { get; set; }

        [JsonProperty("click_rate")]
        public double ClickRate { get; set; }

        [JsonProperty("bounce_rate")]
        public double BounceRate { get; set; }

        [JsonProperty("unopen_rate")]
        public double UnopenRate { get; set; }

        [JsonProperty("unsub_rate")]
        public double UnsubRate { get; set; }

        [JsonProperty("abuse_rate")]
        public double AbuseRate { get; set; }
    }
}