using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    public class Promo
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("amount_discounted")]
        public double AmountDiscounted { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}