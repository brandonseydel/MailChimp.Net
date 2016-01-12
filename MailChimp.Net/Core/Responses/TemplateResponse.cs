using System.Collections.Generic;
using MailChimp.Net.Models;
using Newtonsoft.Json;

namespace MailChimp.Net.Core
{
    public class TemplateResponse
    {
        public TemplateResponse()
        {
            Templates = new HashSet<Template>();
            Links = new HashSet<Link>();
        }

        [JsonProperty("templates")]
        public IEnumerable<Template> Templates { get; set; }

        [JsonProperty("_links")]
        public IEnumerable<Link> Links { get; set; }

        [JsonProperty("total_items")]
        public int TotalItems { get; set; }
    }
}