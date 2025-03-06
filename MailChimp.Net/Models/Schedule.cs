using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    public class Schedule
    {
        [JsonProperty("hour")]
        public int Hour { get; set; }

        [JsonProperty("daily_send")]
        public DailySend DailySend { get; set; }

        [JsonProperty("weekly_send_day")]
        public string DayOfWeekToSend { get; set; }

        [JsonProperty("monthly_send_date")]
        public int DayOfMonthToSend { get; set; }
    }
}