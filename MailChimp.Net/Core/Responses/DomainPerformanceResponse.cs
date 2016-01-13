using System.Collections.Generic;
using MailChimp.Net.Models;
using Newtonsoft.Json;

namespace MailChimp.Net.Core
{
    public class DomainPerformanceResponse : BaseResponse
    {
        public DomainPerformanceResponse()
        {
            Domains = new HashSet<Domain>();
        }

        [JsonProperty("domains")]
        public IEnumerable<Domain> Domains { get; set; }

        [JsonProperty("total_sent")]
        public int TotalSent { get; set; }

        [JsonProperty("campaign_id")]
        public string CampaignId { get; set; }

    }
}