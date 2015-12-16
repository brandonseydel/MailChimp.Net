using MailChimp.Net.Models;
using Newtonsoft.Json;

namespace MailChimp.Net.Core
{
    internal class ListResponse
    {
        [JsonProperty("lists")]
        public List[] Lists { get; set; }

        [JsonProperty("_links")]
        public Models.Link[] Links { get; set; }

        [JsonProperty("total_items")]
        public int TotalItems { get; set; }
    }
}