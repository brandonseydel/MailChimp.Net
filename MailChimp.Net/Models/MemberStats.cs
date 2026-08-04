using MailChimp.Net.Core;

namespace MailChimp.Net.Models;

public class MemberStats
{
    [MailChimpJsonProperty("avg_open_rate")]
    public double AverageOpenRate { get; set; }
    [MailChimpJsonProperty("avg_click_rate")]
    public double AverageClickRate { get; set; }
}
