using System.Collections.Generic;
using MailChimp.Net.Models;
using Newtonsoft.Json;

namespace MailChimp.Net.Core
{
    public class UnsubscribeReportResponse : BaseResponse
    {
        public UnsubscribeReportResponse()
        {
            Unsubscribes = new HashSet<Unsubscribe>();
        }

        [JsonProperty("unsubscribes")]
        public IEnumerable<Unsubscribe> Unsubscribes { get; set; }

        [JsonProperty("campaign_id")]
        public string CampaignId { get; set; }
    }
}