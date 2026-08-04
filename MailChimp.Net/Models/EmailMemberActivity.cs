using MailChimp.Net.Core;

namespace MailChimp.Net.Models;

public class EmailMemberActivity
{
    [MailChimpJsonProperty("action")]
    public string Action { get; set; }

    [MailChimpJsonProperty("timestamp")]
    public string Timestamp { get; set; }

    [MailChimpJsonProperty("type")]
    public string Type { get; set; }

    [MailChimpJsonProperty("url")]
    public string Url { get; set; }

    [MailChimpJsonProperty("ip")]
    public string Ip { get; set; }
}
