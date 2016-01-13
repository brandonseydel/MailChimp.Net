using System.Collections.Generic;
using MailChimp.Net.Models;
using Newtonsoft.Json;

namespace MailChimp.Net.Core
{
    public class SentToResponse : BaseResponse
    {
        public SentToResponse()
        {
            Recipients = new HashSet<SentTo>();
        }

        [JsonProperty("sent_to")]
        public IEnumerable<SentTo> Recipients { get; set; }

        [JsonProperty("campaign_id")]
        public string CampaignId { get; set; }
    }
}