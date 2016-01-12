using System.Collections.Generic;
using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    public class UrlClicked
    {
        public UrlClicked()
        {
            Links = new HashSet<Link>();
        }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("total_clicks")]
        public int TotalClicks { get; set; }

        [JsonProperty("click_percentage")]
        public int ClickPercentage { get; set; }

        [JsonProperty("unique_clicks")]
        public int UniqueClicks { get; set; }

        [JsonProperty("unique_click_percentage")]
        public int UniqueClickPercentage { get; set; }

        [JsonProperty("last_click")]
        public string LastClick { get; set; }

        [JsonProperty("campaign_id")]
        public string CampaignId { get; set; }

        [JsonProperty("_links")]
        public IEnumerable<Link> Links { get; set; }
    }
}