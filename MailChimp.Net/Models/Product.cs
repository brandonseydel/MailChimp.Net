using System.Collections.Generic;
using MailChimp.Net.Core;
namespace MailChimp.Net.Models;

public class Product
{
    [MailChimpJsonProperty("id")]
    public string Id { get; set; }

    [MailChimpJsonProperty("title")]
    public string Title { get; set; }

    [MailChimpJsonProperty("handle")]
    public string Handle { get; set; }

    [MailChimpJsonProperty("url")]
    public string Url { get; set; }

    [MailChimpJsonProperty("description")]
    public string Description { get; set; }

    [MailChimpJsonProperty("type")]
    public string Type { get; set; }

    [MailChimpJsonProperty("vendor")]
    public string Vendor { get; set; }

    [MailChimpJsonProperty("image_url")]
    public string ImageUrl { get; set; }

    [MailChimpJsonProperty("variants")]
    public IList<Variant> Variants { get; set; }

    [MailChimpJsonProperty("published_at_foreign")]
    public string PublishedAtForeign { get; set; }

    [MailChimpJsonProperty("images")]
    public IList<Image> Images { get; set; }

    [MailChimpJsonProperty("_links")]
    public IList<Link> Links { get; set; }
}
