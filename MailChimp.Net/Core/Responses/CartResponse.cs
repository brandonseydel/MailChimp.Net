using System.Collections.Generic;
using MailChimp.Net.Models;
namespace MailChimp.Net.Core;

public class CartResponse
{
    [MailChimpJsonProperty("store_id")]
    public string StoreId { get; set; }

    [MailChimpJsonProperty("carts")]
    public IList<Cart> Carts { get; set; } = new List<Cart>();

    [MailChimpJsonProperty("total_items")]
    public int TotalItems { get; set; }

    [MailChimpJsonProperty("_links")]
    public IList<Link> Links { get; set; } = new List<Link>();
}
