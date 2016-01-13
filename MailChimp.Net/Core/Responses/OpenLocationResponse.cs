using System.Collections.Generic;
using MailChimp.Net.Models;
using Newtonsoft.Json;

namespace MailChimp.Net.Core
{
    public class OpenLocationResponse : BaseResponse
    {
        public OpenLocationResponse()
        {
            Locations = new HashSet<OpenLocation>();
        }

        [JsonProperty("locations")]
        public IEnumerable<OpenLocation> Locations { get; set; }

        [JsonProperty("campaign_id")]
        public string CampaignId { get; set; }
    }
}