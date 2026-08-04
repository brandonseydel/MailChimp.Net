using System.Collections.Generic;
using MailChimp.Net.Models;
namespace MailChimp.Net.Core;

public class CartLineResponse
{

    public CartLineResponse()
    {
        Lines = new List<Line>();
        Links = new List<Link>();
    }

    [MailChimpJsonProperty("store_id")]
    public string StoreId { get; set; }

    [MailChimpJsonProperty("cart_id")]
    public string CartId { get; set; }

    [MailChimpJsonProperty("lines")]
    public ICollection<Line> Lines { get; set; }

    [MailChimpJsonProperty("total_items")]
    public int TotalItems { get; set; }

    [MailChimpJsonProperty("_links")]
    public ICollection<Link> Links { get; set; }
}
