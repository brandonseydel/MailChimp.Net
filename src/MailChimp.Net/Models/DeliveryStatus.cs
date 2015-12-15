using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    internal class DeliveryStatus
    {

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }
    }
}