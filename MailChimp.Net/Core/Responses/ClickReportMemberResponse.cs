using System.Collections.Generic;
using MailChimp.Net.Models;
using Newtonsoft.Json;

namespace MailChimp.Net.Core
{
    public class ClickReportMemberResponse
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

        [JsonProperty("_links")]
        public IEnumerable<Link> Links { get; set; }

        [JsonProperty("total_items")]
        public int TotalItems { get; set; }
    }
}
