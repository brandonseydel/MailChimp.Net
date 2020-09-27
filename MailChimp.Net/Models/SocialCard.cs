using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    public class SocialCard
    {
        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }
}