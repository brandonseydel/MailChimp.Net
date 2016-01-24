using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailChimp.Net.Models;
using Newtonsoft.Json;

namespace MailChimp.Net.Core
{
    public class InterestCategoryResponse
    {
        public InterestCategoryResponse()
        {
            Links = new HashSet<Link>();   
            Categories = new HashSet<InterestCategory>();
        }

        [JsonProperty("list_id")]
        public string ListId { get; set; }

        [JsonProperty("categories")]
        public IEnumerable<InterestCategory> Categories { get; set; }

        [JsonProperty("_links")]
        public IEnumerable<Link> Links { get; set; }

        [JsonProperty("total_items")]
        public int TotalItems { get; set; }
    }
}

