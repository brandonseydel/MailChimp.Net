using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    public class FacebookLikes
    {

        [JsonProperty("recipient_likes")]
        public int RecipientLikes { get; set; }

        [JsonProperty("unique_likes")]
        public int UniqueLikes { get; set; }

        [JsonProperty("facebook_likes")]
        public int FacebookLikeCount { get; set; }
    }
}