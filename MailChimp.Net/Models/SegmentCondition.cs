using Newtonsoft.Json;
using System;

namespace MailChimp.Net.Models
{
    public class SegmentCondition
    {
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("operator")]
        public string Operator { get; set; }
        [JsonProperty("extra")]
        public string Extra { get; set; }
        [JsonProperty("field")]
        public string Field { get; set; }
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
