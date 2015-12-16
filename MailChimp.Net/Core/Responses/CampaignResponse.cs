using System.Collections.Generic;
using MailChimp.Net.Models;
using Newtonsoft.Json;

namespace MailChimp.Net.Core
{
    public class CampaignResponse
    {

        [JsonProperty("campaigns")]
        public IEnumerable<Campaign> Campaigns { get; set; }

        [JsonProperty("total_items")]
        public int TotalItems { get; set; }

        [JsonProperty("_links")]
        public IEnumerable<Models.Link> Links { get; set; }
    }

}
