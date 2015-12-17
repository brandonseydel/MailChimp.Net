using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    public class App
    {
        [JsonProperty("id")]
        public object Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("users")]
        public string[] Users { get; set; }

        [JsonProperty("_links")]
        public Link[] Links { get; set; }
    }
}