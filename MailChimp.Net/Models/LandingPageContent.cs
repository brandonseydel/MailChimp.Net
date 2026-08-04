using System.Collections.Generic;
using MailChimp.Net.Core;
namespace MailChimp.Net.Models;

public class LandingPageContent
{
    public LandingPageContent()
    {
        Links = new HashSet<Link>();
    }

    [MailChimpJsonProperty("html")]
    public string Html { get; set; }

    [MailChimpJsonProperty("json")]
    public string Json { get; set; }

    [MailChimpJsonProperty("_links")]
    public IEnumerable<Link> Links { get; set; }
}
