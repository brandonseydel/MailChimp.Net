using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    public class DeliveryStatus
    {

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }
    }
}