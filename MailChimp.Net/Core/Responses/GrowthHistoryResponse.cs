using System.Collections.Generic;
using MailChimp.Net.Models;
using Newtonsoft.Json;

namespace MailChimp.Net.Core
{
    public class GrowthHistoryResponse
    {
        public GrowthHistoryResponse()
        {
            History = new HashSet<History>();
            Links = new HashSet<Link>();
        }

        [JsonProperty("history")]
        public IEnumerable<History> History { get; set; }

        [JsonProperty("list_id")]
        public string ListId { get; set; }

        [JsonProperty("total_items")]
        public int TotalItems { get; set; }

        [JsonProperty("_links")]
        public IEnumerable<Link> Links { get; set; }
    }
}