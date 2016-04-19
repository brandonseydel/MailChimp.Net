using MailChimp.Net.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailChimp.Net.Core
{
    public class ECommerceResponse
    {
        public ECommerceResponse()
        {
            this.Links = new HashSet<Link>();
        }

        [JsonProperty("stores")]
        public IEnumerable<Store> Stores { get; set; }

        [JsonProperty("total_items")]
        public int TotalItems { get; set; }

        [JsonProperty("_links")]
        public IEnumerable<Link> Links { get; set; }
    }
}
