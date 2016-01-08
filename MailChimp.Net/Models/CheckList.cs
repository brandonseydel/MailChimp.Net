using MailChimp.Net.Core;
using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    public class CheckList
    {

        [JsonProperty("type")]
        public Result Type { get; set; }

        [JsonProperty("heading")]
        public string Heading { get; set; }

        [JsonProperty("details")]
        public string Details { get; set; }
    }
}