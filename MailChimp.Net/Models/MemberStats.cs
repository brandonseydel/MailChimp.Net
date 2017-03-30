using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    public class MemberStats
    {
        [JsonProperty("avg_open_rate")]
        public double AverageOpenRate { get; set; }
        [JsonProperty("avg_click_rate")]
        public double AverageClickRate { get; set; }
    }
}
