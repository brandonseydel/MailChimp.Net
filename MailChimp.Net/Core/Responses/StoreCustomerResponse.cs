using System.Collections.Generic;
using MailChimp.Net.Models;
using Newtonsoft.Json;

namespace MailChimp.Net.Core;

public class StoreCustomerResponse : BaseResponse
{

    public StoreCustomerResponse()
    {
        Customers = new List<Customer>();
    }

    [JsonProperty("store_id")]
    public string StoreId { get; set; }

    [JsonProperty("customers")]
    public IList<Customer> Customers { get; set; }
}
