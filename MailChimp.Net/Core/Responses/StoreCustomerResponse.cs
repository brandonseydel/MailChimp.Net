using System.Collections.Generic;
using MailChimp.Net.Models;
namespace MailChimp.Net.Core;

public class StoreCustomerResponse : BaseResponse
{

    public StoreCustomerResponse()
    {
        Customers = new List<Customer>();
    }

    [MailChimpJsonProperty("store_id")]
    public string StoreId { get; set; }

    [MailChimpJsonProperty("customers")]
    public IList<Customer> Customers { get; set; }
}
