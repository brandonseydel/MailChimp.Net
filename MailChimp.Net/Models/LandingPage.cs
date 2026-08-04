using System.Collections.Generic;
using MailChimp.Net.Core;
namespace MailChimp.Net.Models;

public class LandingPage
{
    public LandingPage()
    {
        Links = new HashSet<Link>();
    }

    [MailChimpJsonProperty("id")]
    public string Id { get; set; }

    [MailChimpJsonProperty("name")]
    public string Name { get; set; }

    [MailChimpJsonProperty("title")]
    public string Title { get; set; }

    [MailChimpJsonProperty("description")]
    public string Description { get; set; }

    [MailChimpJsonProperty("template_id")]
    public int? TemplateId { get; set; }

    [MailChimpJsonProperty("status")]
    public string Status { get; set; }

    [MailChimpJsonProperty("list_id")]
    public string ListId { get; set; }

    [MailChimpJsonProperty("store_id")]
    public string StoreId { get; set; }

    [MailChimpJsonProperty("webview_url")]
    public string WebviewUrl { get; set; }

    [MailChimpJsonProperty("created_at")]
    public string CreatedAt { get; set; }

    [MailChimpJsonProperty("published_at")]
    public string PublishedAt { get; set; }

    [MailChimpJsonProperty("updated_at")]
    public string UpdatedAt { get; set; }

    [MailChimpJsonProperty("tracking")]
    public Tracking Tracking { get; set; }

    [MailChimpJsonProperty("_links")]
    public IEnumerable<Link> Links { get; set; }
}
