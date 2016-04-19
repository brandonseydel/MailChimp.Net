using MailChimp.Net.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailChimp.Net.Core
{
    public class WebHook
    {

        public WebHook()
        {
            this.Links = new HashSet<Link>();
        }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("events")]
        public Event Event { get; set; }

        [JsonProperty("sources")]
        public Source Source { get; set; }

        [JsonProperty("list_id")]
        public string ListId { get; set; }

        [JsonProperty("_links")]
        public IEnumerable<Link> Links { get; set; }
    }
}
