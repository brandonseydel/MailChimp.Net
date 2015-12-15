using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    internal class Forwards
    {

        [JsonProperty("forwards_count")]
        public int ForwardsCount { get; set; }

        [JsonProperty("forwards_opens")]
        public int ForwardsOpens { get; set; }
    }
}