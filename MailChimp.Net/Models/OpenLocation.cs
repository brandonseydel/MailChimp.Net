using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    public class OpenLocation
    {

        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("opens")]
        public int Opens { get; set; }
    }
}