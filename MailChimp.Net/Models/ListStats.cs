using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    public class ListStats
    {

        [JsonProperty("sub_rate")]
        public int SubRate { get; set; }

        [JsonProperty("unsub_rate")]
        public int UnsubRate { get; set; }

        [JsonProperty("open_rate")]
        public int OpenRate { get; set; }

        [JsonProperty("click_rate")]
        public int ClickRate { get; set; }
    }
}