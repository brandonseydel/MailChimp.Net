using Newtonsoft.Json;
using System.Collections.Generic;

namespace MailChimp.Net.Models
{

    public class CampaignResponse
    {

        [JsonProperty("campaigns")]
        public IEnumerable<Campaign> Campaigns { get; set; }

        [JsonProperty("total_items")]
        public int TotalItems { get; set; }

        [JsonProperty("_links")]
        public IEnumerable<Link> Links { get; set; }
    }

}
