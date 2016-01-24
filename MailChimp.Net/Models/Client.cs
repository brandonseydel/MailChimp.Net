using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    public class Client
    {

        [JsonProperty("client")]
        public string ClientName { get; set; }

        [JsonProperty("members")]
        public int Members { get; set; }

        [JsonProperty("list_id")]
        public string ListId { get; set; }
    }
}