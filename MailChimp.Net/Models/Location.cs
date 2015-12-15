using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    public class Location
    {

        [JsonProperty("latitude")]
        public int Latitude { get; set; }

        [JsonProperty("longitude")]
        public int Longitude { get; set; }

        [JsonProperty("gmtoff")]
        public int Gmtoff { get; set; }

        [JsonProperty("dstoff")]
        public int Dstoff { get; set; }

        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }
    }
}