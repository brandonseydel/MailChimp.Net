using MailChimp.Net.Models;
using Newtonsoft.Json;

namespace MailChimp.Net.Responses
{
    internal class ListResponse
    {
        [JsonProperty("lists")]
        public List[] Lists { get; set; }

        [JsonProperty("_links")]
        public Link[] Links { get; set; }

        [JsonProperty("total_items")]
        public int TotalItems { get; set; }
    }
}