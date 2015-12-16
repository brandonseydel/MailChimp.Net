using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    public class Condition
    {

        [JsonProperty("field")]
        public string Field { get; set; }

        [JsonProperty("op")]
        public string Op { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }
    }
}
