using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    public class Domain
    {

        [JsonProperty("domain")]
        public string DomainName { get; set; }

        [JsonProperty("emails_sent")]
        public int EmailsSent { get; set; }

        [JsonProperty("bounces")]
        public int Bounces { get; set; }

        [JsonProperty("opens")]
        public int Opens { get; set; }

        [JsonProperty("clicks")]
        public int Clicks { get; set; }

        [JsonProperty("unsubs")]
        public int Unsubs { get; set; }

        [JsonProperty("delivered")]
        public int Delivered { get; set; }

        [JsonProperty("emails_pct")]
        public int EmailsPct { get; set; }

        [JsonProperty("bounces_pct")]
        public int BouncesPct { get; set; }

        [JsonProperty("opens_pct")]
        public int OpensPct { get; set; }

        [JsonProperty("clicks_pct")]
        public int ClicksPct { get; set; }

        [JsonProperty("unsubs_pct")]
        public int UnsubsPct { get; set; }
    }
}