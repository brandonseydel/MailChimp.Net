using Newtonsoft.Json;
using System.Collections.Generic;
using System.Diagnostics;

namespace MailChimp.Net.Models
{
    public class CampaignSearchResult : Base
    {
        public CampaignSearchResult()
        {
            Results = new List<Result>();
            Links = new List<Link>();
        }

        [JsonProperty("results")]
        public IEnumerable<Result> Results { get; set; }

        [JsonProperty("total_items")]
        public int TotalItems { get; set; }

        [JsonProperty("_links")]
        public IEnumerable<Link> Links { get; set; }

        internal override DisplayBuilder GetDebuggerDisplayBuilder(DisplayBuilder Builder) {
            return base.GetDebuggerDisplayBuilder(Builder)
                .Data.AddExpression(TotalItems)
                ;
        }
    }
}
