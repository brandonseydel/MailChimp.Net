using System.Collections.Generic;
using MailChimp.Net.Models;
using Newtonsoft.Json;

namespace MailChimp.Net.Core
{
    public class Segment
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("static_segment", NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> EmailAddresses { get; set; }
        [JsonProperty("options", NullValueHandling = NullValueHandling.Ignore)]
		public SegmentOptions Options { get; set; }
    }
}
