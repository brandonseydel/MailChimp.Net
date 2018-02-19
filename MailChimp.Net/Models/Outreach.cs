using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    public class Outreach
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }
}