using System.Collections.Generic;
using MailChimp.Net.Models;
namespace MailChimp.Net.Core;

public class ProductVariantResponse : BaseResponse
{

    public ProductVariantResponse()
    {
        Variants = new List<Variant>();
    }

    [MailChimpJsonProperty("store_id")]
    public string StoreId { get; set; }

    [MailChimpJsonProperty("product_id")]
    public string ProductId { get; set; }

    [MailChimpJsonProperty("variants")]
    public IList<Variant> Variants { get; set; }
}
