using System.Collections.Generic;
using MailChimp.Net.Models;
using Newtonsoft.Json;

namespace MailChimp.Net.Core
{
    public class BatchWebHookResponse
    {
        [JsonProperty("webhooks")]
        public IEnumerable<BatchWebHook> WebHooks { get; set; }
        [JsonProperty("url")]
        public string Url { get; set; }
        [JsonProperty("_links")]
        public IEnumerable<Link> Links { get; set; }
    }
}
