using System.Collections.Generic;
using MailChimp.Net.Core;
namespace MailChimp.Net.Models;

public class Line
{

    public Line()
    {
        Links = new List<Link>();
    }

    [MailChimpJsonProperty("id")]
    public string Id { get; set; }

    [MailChimpJsonProperty("product_id")]
    public string ProductId { get; set; }

    [MailChimpJsonProperty("product_title")]
    public string ProductTitle { get; set; }

    [MailChimpJsonProperty("product_variant_id")]
    public string ProductVariantId { get; set; }

    [MailChimpJsonProperty("product_variant_title")]
    public string ProductVariantTitle { get; set; }

    [MailChimpJsonProperty("quantity")]
    public int Quantity { get; set; }

    [MailChimpJsonProperty("price")]
    public decimal Price { get; set; }

    [MailChimpJsonProperty("discount")]
    public decimal? Discount { get; set; }

    [MailChimpJsonProperty("_links")]
    public IList<Link> Links { get; set; }
}
