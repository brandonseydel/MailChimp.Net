using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    public class Opens
    {

        [JsonProperty("opens_total")]
        public int OpensTotal { get; set; }

        [JsonProperty("unique_opens")]
        public int UniqueOpens { get; set; }

        [JsonProperty("open_rate")]
        public int OpenRate { get; set; }

        [JsonProperty("last_open")]
        public string LastOpen { get; set; }
    }
}