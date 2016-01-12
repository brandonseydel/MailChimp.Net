using System.Collections.Generic;
using MailChimp.Net.Models;
using Newtonsoft.Json;

namespace MailChimp.Net.Core
{
    public class CampaignAdviceReport
    {
        public CampaignAdviceReport()
        {
            Advice = new HashSet<Advice>();
            Links = new HashSet<Link>();
        }


        [JsonProperty("advice")]
        public IEnumerable<Advice> Advice { get; set; }

        [JsonProperty("campaign_id")]
        public string CampaignId { get; set; }

        [JsonProperty("_links")]
        public IEnumerable<Link> Links { get; set; }

        [JsonProperty("total_items")]
        public int TotalItems { get; set; }
    }
}