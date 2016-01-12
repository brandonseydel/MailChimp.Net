using System.Collections.Generic;
using MailChimp.Net.Models;
using Newtonsoft.Json;

namespace MailChimp.Net.Core
{
    public class ClickReportResponse
    {
        public ClickReportResponse()
        {
            UrlsClicked = new HashSet<UrlClicked>();
            Links = new HashSet<Link>();
        }
        [JsonProperty("urls_clicked")]
        public IEnumerable<UrlClicked> UrlsClicked { get; set; }

        [JsonProperty("campaign_id")]
        public string CampaignId { get; set; }

        [JsonProperty("_links")]
        public IEnumerable<Link> Links { get; set; }

        [JsonProperty("total_items")]
        public int TotalItems { get; set; }
    }
}
