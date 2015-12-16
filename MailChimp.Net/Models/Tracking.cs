using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    public class Tracking
    {

        [JsonProperty("opens")]
        public bool Opens { get; set; }

        [JsonProperty("html_clicks")]
        public bool HtmlClicks { get; set; }

        [JsonProperty("text_clicks")]
        public bool TextClicks { get; set; }

        [JsonProperty("goal_tracking")]
        public bool GoalTracking { get; set; }

        [JsonProperty("ecomm360")]
        public bool Ecomm360 { get; set; }

        [JsonProperty("google_analytics")]
        public bool? GoogleAnalytics { get; set; }

        [JsonProperty("clicktale")]
        public string Clicktale { get; set; }
    }
}