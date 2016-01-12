using System.Collections.Generic;
using MailChimp.Net.Models;
using Newtonsoft.Json;

namespace MailChimp.Net.Core
{
    public class DomainPerformanceResponse
    {
        public DomainPerformanceResponse()
        {
            Domains = new HashSet<Domain>();
            Links = new HashSet<Link>();
        }

        [JsonProperty("domains")]
        public IEnumerable<Domain> Domains { get; set; }

        [JsonProperty("total_sent")]
        public int TotalSent { get; set; }

        [JsonProperty("campaign_id")]
        public string CampaignId { get; set; }

        [JsonProperty("_links")]
        public IEnumerable<Link> Links { get; set; }

        [JsonProperty("total_items")]
        public int TotalItems { get; set; }
    }
}