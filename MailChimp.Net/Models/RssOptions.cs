using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    public class RssOptions
    {
        [JsonProperty("feed_url")]
        public string Url { get; set; }
        [JsonProperty("frequency")]
        public string Frequency { get; set; }
        [JsonProperty("schedule")]
        public Schedule Schedule { get; set; }
        [JsonProperty("constrain_rss_img")]
        public bool ConstrainImage { get; set; }
    }
}