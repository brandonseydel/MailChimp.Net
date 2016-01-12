using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    public class Clicks
    {

        [JsonProperty("clicks_total")]
        public int ClicksTotal { get; set; }

        [JsonProperty("unique_clicks")]
        public int UniqueClicks { get; set; }

        [JsonProperty("unique_subscriber_clicks")]
        public int UniqueSubscriberClicks { get; set; }

        [JsonProperty("click_rate")]
        public int ClickRate { get; set; }

        [JsonProperty("last_click")]
        public string LastClick { get; set; }
    }
}