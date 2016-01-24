using Newtonsoft.Json;
using System.Collections.Generic;

namespace MailChimp.Net.Models
{
    public class Interest
    {
        public Interest()
        {
            Links = new HashSet<Link>();
        }

        [JsonProperty("category_id")]
        public string InterestCategoryId { get; set; }

        [JsonProperty("list_id")]
        public string ListId { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("display_order")]
        public int DisplayOrder { get; set; }

        [JsonProperty("_links")]
        public IEnumerable<Link> Links { get; set; }
    }
}
