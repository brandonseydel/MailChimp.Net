using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    public class InterestCategory
    {
        [JsonProperty("list_id")]
        public string ListId { get; }

        [JsonProperty("id")]
        public string Id { get; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("display_order")]
        public int DisplayOrder { get; set; }

        [JsonProperty("type")]
        public string DisplayType { get; set; }
    }
}
