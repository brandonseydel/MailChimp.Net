using System.Collections.Generic;
using MailChimp.Net.Models;
using Newtonsoft.Json;

namespace MailChimp.Net.Core
{
    public class GoalResponse
    {
        public GoalResponse()
        {
            Goals = new HashSet<Goal>();
            Links = new HashSet<Link>();
        }
        [JsonProperty("goals")]
        public IEnumerable<Goal> Goals { get; set; }

        [JsonProperty("list_id")]
        public string ListId { get; set; }

        [JsonProperty("email_id")]
        public string EmailId { get; set; }

        [JsonProperty("_links")]
        public IEnumerable<Link> Links { get; set; }

        [JsonProperty("total_items")]
        public int TotalItems { get; set; }
    }
}