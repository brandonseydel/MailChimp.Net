using Newtonsoft.Json;
using System.Diagnostics;

namespace MailChimp.Net.Models
{
    public class Schedule : Base
    {
        [JsonProperty("hour")]
        public int Hour { get; set; }

        [JsonProperty("daily_send")]
        public DailySend DailySend { get; set; }

        [JsonProperty("weekly_send_day")]
        public string DayOfWeekToSend { get; set; }

        [JsonProperty("monthly_send_date")]
        public int DayOfMonthToSend { get; set; }

        internal override DisplayBuilder GetDebuggerDisplayBuilder(DisplayBuilder Builder) {
            return base.GetDebuggerDisplayBuilder(Builder)
                ;
        }
    }
}