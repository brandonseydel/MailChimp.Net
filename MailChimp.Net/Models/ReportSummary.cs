using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    public class ReportSummary
    {

        [JsonProperty("opens")]
        public int Opens { get; set; }

        [JsonProperty("unique_opens")]
        public int UniqueOpens { get; set; }

        [JsonProperty("open_rate")]
        public int OpenRate { get; set; }

        [JsonProperty("clicks")]
        public int Clicks { get; set; }

        [JsonProperty("subscriber_clicks")]
        public int SubscriberClicks { get; set; }

        [JsonProperty("click_rate")]
        public int ClickRate { get; set; }
    }
}
