using System;
using System.Collections.Generic;
using MailChimp.Net.Core;
namespace MailChimp.Net.Models;

public class Variant
{
    [MailChimpJsonProperty("id")]
    public string Id { get; set; }

    [MailChimpJsonProperty("title")]
    public string Title { get; set; }

    [MailChimpJsonProperty("url")]
    public string Url { get; set; }

    [MailChimpJsonProperty("sku")]
    public string Sku { get; set; }

    [MailChimpJsonProperty("price")]
    public decimal? Price { get; set; }

    [MailChimpJsonProperty("inventory_quantity")]
    public int? InventoryQuantity { get; set; }

    [MailChimpJsonProperty("image_url")]
    public string ImageUrl { get; set; }

    [MailChimpJsonProperty("backorders")]
    public string Backorders { get; set; }

    [MailChimpJsonProperty("visibility")]
    public string Visibility { get; set; }

    [MailChimpJsonProperty("created_at")]
    public DateTime? CreatedAt { get; set; }

    [MailChimpJsonProperty("updated_at")]
    public DateTime? UpdatedAt { get; set; }

    [MailChimpJsonProperty("_links")]
    public IList<Link> Links { get; set; }
}
