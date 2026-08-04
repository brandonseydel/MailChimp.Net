using System.Collections.Generic;
using MailChimp.Net.Models;
namespace MailChimp.Net.Core;

public class StoreOrderResponse : BaseResponse
{

    public StoreOrderResponse()
    {
        Orders = new List<Order>();
    }

    [MailChimpJsonProperty("store_id")]
    public string StoreId { get; set; }

    [MailChimpJsonProperty("orders")]
    public IList<Order> Orders { get; set; }
}
