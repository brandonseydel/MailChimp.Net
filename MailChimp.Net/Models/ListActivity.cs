using MailChimp.Net.Core;

namespace MailChimp.Net.Models;

public class ListActivity
{

    [MailChimpJsonProperty("day")]
    public string Day { get; set; }

    [MailChimpJsonProperty("emails_sent")]
    public int EmailsSent { get; set; }

    [MailChimpJsonProperty("unique_opens")]
    public int UniqueOpens { get; set; }

    [MailChimpJsonProperty("recipient_clicks")]
    public int RecipientClicks { get; set; }

    [MailChimpJsonProperty("hard_bounce")]
    public int HardBounce { get; set; }

    [MailChimpJsonProperty("soft_bounce")]
    public int SoftBounce { get; set; }

    [MailChimpJsonProperty("subs")]
    public int Subs { get; set; }

    [MailChimpJsonProperty("unsubs")]
    public int Unsubs { get; set; }

    [MailChimpJsonProperty("other_adds")]
    public int OtherAdds { get; set; }

    [MailChimpJsonProperty("other_removes")]
    public int OtherRemoves { get; set; }
}
