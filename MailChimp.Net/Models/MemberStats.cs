using Newtonsoft.Json;
using System.Diagnostics;

namespace MailChimp.Net.Models
{
    public class MemberStats : Base
    {
        [JsonProperty("avg_open_rate")]
        public double AverageOpenRate { get; set; }
        [JsonProperty("avg_click_rate")]
        public double AverageClickRate { get; set; }

        internal override DisplayBuilder GetDebuggerDisplayBuilder(DisplayBuilder Builder) {
            return base.GetDebuggerDisplayBuilder(Builder)
                .Data.AddExpression(AverageOpenRate)
                .Data.AddExpression(AverageClickRate)
                ;
        }
    }
}
