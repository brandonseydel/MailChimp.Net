using System.Collections.Generic;
using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    public class Image
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("url")]
        public IList<string> VariantIds { get; set; }

        [JsonProperty("_links")]
        public IList<Link> Links { get; set; }
    }
}