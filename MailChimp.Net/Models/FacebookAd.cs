using System.Collections.Generic;
using MailChimp.Net.Core;
namespace MailChimp.Net.Models;

public class FacebookAd
{
    public FacebookAd()
    {
        Links = new HashSet<Link>();
    }

    [MailChimpJsonProperty("id")]
    public string Id { get; set; }

    [MailChimpJsonProperty("name")]
    public string Name { get; set; }

    [MailChimpJsonProperty("type")]
    public string Type { get; set; }

    [MailChimpJsonProperty("status")]
    public string Status { get; set; }

    [MailChimpJsonProperty("create_time")]
    public string CreateTime { get; set; }

    [MailChimpJsonProperty("updated_at")]
    public string UpdatedAt { get; set; }

    [MailChimpJsonProperty("canceled_at")]
    public string CanceledAt { get; set; }

    [MailChimpJsonProperty("published_time")]
    public string PublishedTime { get; set; }

    [MailChimpJsonProperty("end_time")]
    public string EndTime { get; set; }

    [MailChimpJsonProperty("_links")]
    public IEnumerable<Link> Links { get; set; }
}
