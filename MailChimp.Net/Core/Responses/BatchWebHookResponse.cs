using System.Collections.Generic;
using MailChimp.Net.Models;
namespace MailChimp.Net.Core;

public class BatchWebHookResponse
{
    [MailChimpJsonProperty("webhooks")]
    public IEnumerable<BatchWebHook> WebHooks { get; set; }
    [MailChimpJsonProperty("url")]
    public string Url { get; set; }
    [MailChimpJsonProperty("_links")]
    public IEnumerable<Link> Links { get; set; }
}
