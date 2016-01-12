using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    public class ShareReport
    {

        [JsonProperty("share_url")]
        public string ShareUrl { get; set; }

        [JsonProperty("share_password")]
        public string SharePassword { get; set; }
    }
}