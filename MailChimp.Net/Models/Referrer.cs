using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    public class Referrer
    {
        [JsonProperty("referrer")]
        public string Name { get; set; }

        public int Clicks { get; set; }

        [JsonProperty("first_click")]
        public string FirstClick { get; set; }

        [JsonProperty("last_click")]
        public string LastClick { get; set; }
    }
}