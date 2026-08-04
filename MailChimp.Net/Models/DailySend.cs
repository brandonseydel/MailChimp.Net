using MailChimp.Net.Core;

namespace MailChimp.Net.Models;

public class DailySend
{
    [MailChimpJsonProperty("sunday")]
    public bool Sunday { get; set; }

    [MailChimpJsonProperty("monday")]
    public bool Monday { get; set; }

    [MailChimpJsonProperty("tuesday")]
    public bool Tuesday { get; set; }

    [MailChimpJsonProperty("wednesday")]
    public bool Wednesday { get; set; }

    [MailChimpJsonProperty("thursday")]
    public bool Thursday { get; set; }

    [MailChimpJsonProperty("friday")]
    public bool Friday { get; set; }

    [MailChimpJsonProperty("saturday")]
    public bool Saturday { get; set; }
}