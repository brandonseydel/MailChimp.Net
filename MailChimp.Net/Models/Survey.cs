using System.Collections.Generic;
using MailChimp.Net.Core;
namespace MailChimp.Net.Models;

public class Survey
{
    public Survey()
    {
        Links = new HashSet<Link>();
    }

    [MailChimpJsonProperty("id")]
    public string Id { get; set; }

    [MailChimpJsonProperty("list_id")]
    public string ListId { get; set; }

    [MailChimpJsonProperty("web_id")]
    public int WebId { get; set; }

    [MailChimpJsonProperty("title")]
    public string Title { get; set; }

    [MailChimpJsonProperty("status")]
    public string Status { get; set; }

    [MailChimpJsonProperty("published_at")]
    public string PublishedAt { get; set; }

    [MailChimpJsonProperty("created_at")]
    public string CreatedAt { get; set; }

    [MailChimpJsonProperty("updated_at")]
    public string UpdatedAt { get; set; }

    [MailChimpJsonProperty("_links")]
    public IEnumerable<Link> Links { get; set; }
}
