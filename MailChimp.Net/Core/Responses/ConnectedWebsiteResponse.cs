using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailChimp.Net.Models;
using Newtonsoft.Json;

namespace MailChimp.Net.Core
{
    public class ConnectedWebsiteResponse
    {
        [JsonProperty("sites")]
        public IEnumerable<Site> Sites { get; set; } = new HashSet<Site>();

        [JsonProperty("total_items")]
        public int TotalItems { get; set; }

        [JsonProperty("_links")]
        public IEnumerable<Link> Links { get; set; } = new HashSet<Link>();
    }
}