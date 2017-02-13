using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailChimp.Net.Models
{
    public class CampaignSearchResult
    {
        public CampaignSearchResult()
        {
            this.Results = new List<Result>();
            this.Links = new List<Link>();
        }

        [JsonProperty("results")]
        public IEnumerable<Result> Results { get; set; }

        [JsonProperty("total_items")]
        public int TotalItems { get; set; }

        [JsonProperty("_links")]
        public IEnumerable<Link> Links { get; set; }
    }
}
