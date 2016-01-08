using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    public class Hours
    {
        [JsonProperty("send_at")]
        public string SendAt { get; set; }
    }
}