using System.Collections.Generic;
using MailChimp.Net.Models;
namespace MailChimp.Net.Core;

public class StoreProductResponse : BaseResponse
{

    public StoreProductResponse()
    {
        Products = new List<Product>();
    }
    [MailChimpJsonProperty("store_id")]
    public string StoreId { get; set; }

    [MailChimpJsonProperty("products")]
    public IList<Product> Products { get; set; }
}
