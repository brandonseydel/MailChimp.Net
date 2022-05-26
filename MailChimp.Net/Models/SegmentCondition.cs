using Newtonsoft.Json;
using System.Diagnostics;

namespace MailChimp.Net.Models
{
    public class SegmentCondition : Base
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

        internal override DisplayBuilder GetDebuggerDisplayBuilder(DisplayBuilder Builder) {
            return base.GetDebuggerDisplayBuilder(Builder)
                .Type.Add(Type)
                .Data.Add(Field, Operator, Value)
                .Postfix.Add(Extra)
                ;
        }
    }
}
