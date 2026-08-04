using System.Collections.Generic;
using MailChimp.Net.Core;
namespace MailChimp.Net.Models;

public class WebHook
{

    public WebHook()
    {
        Links = new HashSet<Link>();
    }

    [MailChimpJsonProperty("id")]
    public string Id { get; set; }

    [MailChimpJsonProperty("url")]
    public string Url { get; set; }

    [MailChimpJsonProperty("events")]
    public Event Event { get; set; }

    [MailChimpJsonProperty("sources")]
    public Source Source { get; set; }

    [MailChimpJsonProperty("list_id")]
    public string ListId { get; set; }

    [MailChimpJsonProperty("_links")]
    public IEnumerable<Link> Links { get; set; }
}
