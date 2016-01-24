using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailChimp.Net.Models;
using Newtonsoft.Json;

namespace MailChimp.Net.Core
{
    public class InterestResponse
    {
        public InterestResponse()
        {
            Links = new HashSet<Link>();
            Interests = new HashSet<Interest>();
        }
        [JsonProperty("interests")]
        public IEnumerable<Interest> Interests { get; set; }

        [JsonProperty("list_id")]
        public string ListId { get; set; }

        [JsonProperty("category_id")]
        public string CategoryId { get; set; }

        [JsonProperty("_links")]
        public IEnumerable<Link> Links { get; set; }

        [JsonProperty("total_items")]
        public int TotalItems { get; set; }
    }
}