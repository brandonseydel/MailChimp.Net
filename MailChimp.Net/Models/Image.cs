using System.Collections.Generic;
using MailChimp.Net.Core;
namespace MailChimp.Net.Models;

public class Image
{
    [MailChimpJsonProperty("id")]
    public string Id { get; set; }

    [MailChimpJsonProperty("url")]
    public string Url { get; set; }

    [MailChimpJsonProperty("variant_ids")]
    public IList<string> VariantIds { get; set; }

    [MailChimpJsonProperty("_links")]
    public IList<Link> Links { get; set; }
}