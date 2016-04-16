using System.Collections.Generic;
using MailChimp.Net.Models;
using Newtonsoft.Json;

namespace MailChimp.Net.Core
{
    public class Segment
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("static_segment")]
        public IEnumerable<string> EmailAddresses { get; set; }
        [JsonProperty("options")]
        public IEnumerable<SegmentOptions> Options { get; set; }
    }
}
