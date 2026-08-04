using MailChimp.Net.Core;

namespace MailChimp.Net.Models;

public class Schedule
{
    [MailChimpJsonProperty("hour")]
    public int Hour { get; set; }

    [MailChimpJsonProperty("daily_send")]
    public DailySend DailySend { get; set; }

    [MailChimpJsonProperty("weekly_send_day")]
    public string DayOfWeekToSend { get; set; }

    [MailChimpJsonProperty("monthly_send_date")]
    public int DayOfMonthToSend { get; set; }
}