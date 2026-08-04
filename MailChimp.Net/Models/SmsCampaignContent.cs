using System.Collections.Generic;
using MailChimp.Net.Core;
namespace MailChimp.Net.Models;

public class SmsCampaignContent
{
    public SmsCampaignContent()
    {
        Links = new HashSet<Link>();
    }

    [MailChimpJsonProperty("message")]
    public string Message { get; set; }

    [MailChimpJsonProperty("_links")]
    public IEnumerable<Link> Links { get; set; }
}
