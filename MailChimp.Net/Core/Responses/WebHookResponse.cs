using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using MailChimp.Net.Models;

namespace MailChimp.Net.Core
{
    public class WebHookResponse
    {

        public WebHookResponse()
        {
            this.Webhooks = new HashSet<WebHook>();
            this.Links = new HashSet<Link>();
        }

        [JsonProperty("webhooks")]
        public IEnumerable<WebHook> Webhooks { get; set; }

        [JsonProperty("list_id")]
        public string ListId { get; set; }

        [JsonProperty("total_items")]
        public int TotalItems { get; set; }

        [JsonProperty("_links")]
        public IEnumerable<Link> Links { get; set; }
    }
}

