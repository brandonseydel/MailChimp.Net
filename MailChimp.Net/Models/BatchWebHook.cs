using System.Collections.Generic;
using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    public class BatchWebHook
    {

        public string Id { get; set; }
        public string Url { get; set; }

        [JsonProperty("_links")]
        public IEnumerable<Link> Links { get; set; }

    }
}
