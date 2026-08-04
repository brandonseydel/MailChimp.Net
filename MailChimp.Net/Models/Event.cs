using MailChimp.Net.Core;

namespace MailChimp.Net.Models;

public class Event
{
    [MailChimpJsonProperty("subscribe")]
    public bool Subscribe { get; set; }

    [MailChimpJsonProperty("unsubscribe")]
    public bool Unsubscribe { get; set; }

    [MailChimpJsonProperty("profile")]
    public bool Profile { get; set; }

    [MailChimpJsonProperty("cleaned")]
    public bool Cleaned { get; set; }

    [MailChimpJsonProperty("upemail")]
    public bool Upemail { get; set; }

    [MailChimpJsonProperty("campaign")]
    public bool Campaign { get; set; }
}
