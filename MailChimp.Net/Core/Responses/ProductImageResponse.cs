using System.Collections.Generic;
using MailChimp.Net.Models;
namespace MailChimp.Net.Core;

public class ProductImageResponse : BaseResponse
{
    public ProductImageResponse()
    {
        Images = new HashSet<Image>();
    }

    [MailChimpJsonProperty("images")]
    public IEnumerable<Image> Images { get; set; }

    [MailChimpJsonProperty("store_id")]
    public string StoreId { get; set; }

    [MailChimpJsonProperty("product_id")]
    public string ProductId { get; set; }
}
