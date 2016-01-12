using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    public class Advice
    {

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }
}