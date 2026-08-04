using MailChimp.Net.Core;

namespace MailChimp.Net.Models;

public class Source
{
    [MailChimpJsonProperty("user")]
    public bool User { get; set; }

    [MailChimpJsonProperty("admin")]
    public bool Admin { get; set; }

    [MailChimpJsonProperty("api")]
    public bool Api { get; set; }
}
