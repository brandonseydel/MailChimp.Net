using MailChimp.Net.Core;

namespace MailChimp.Net.Models;

public class SmsCampaignScheduleRequest
{
    [MailChimpJsonProperty("schedule_time")]
    public string ScheduleTime { get; set; }
}
