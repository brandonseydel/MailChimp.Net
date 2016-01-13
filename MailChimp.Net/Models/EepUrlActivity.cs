using System.Collections.Generic;
using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    public class EepUrlActivity
    {
        public Twitter Twitter { get; set; }
        public IEnumerable<EepClick> Clicks { get; set; }
        public IEnumerable<Referrer> Referrers { get; set; }

        public string EepUrl { get; set; }

        [JsonProperty("campaign_id")]
        public string CampaignId { get; set; }

        [JsonProperty("total_items")]
        public string TotalItems { get; set; }
    }
}