using MailChimp.Net.Core;

namespace MailChimp.Net.Models;

public class RssOptions
{
    [MailChimpJsonProperty("feed_url")]
    public string Url { get; set; }
    [MailChimpJsonProperty("frequency")]
    public string Frequency { get; set; }
    [MailChimpJsonProperty("schedule")]
    public Schedule Schedule { get; set; }
    [MailChimpJsonProperty("constrain_rss_img")]
    public bool ConstrainImage { get; set; }
}