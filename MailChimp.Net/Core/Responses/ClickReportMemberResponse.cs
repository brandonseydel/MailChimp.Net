using System.Collections.Generic;
using MailChimp.Net.Models;
using Newtonsoft.Json;

namespace MailChimp.Net.Core
{
    public class ClickReportMemberResponse : BaseResponse
    {
        public ClickReportMemberResponse()
        {
            Members = new HashSet<ClickMember>();
            Links = new HashSet<Link>();
        }

        [JsonProperty("members")]
        public IEnumerable<ClickMember> Members { get; set; }

        [JsonProperty("campaign_id")]
        public string CampaignId { get; set; }
        
    }
}
