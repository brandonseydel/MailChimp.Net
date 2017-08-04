using System.Collections.Generic;
using MailChimp.Net.Models;
using Newtonsoft.Json;

namespace MailChimp.Net.Core
{
    public class StoreOrderResponse : BaseResponse
    {

        public StoreOrderResponse()
        {
            this.Orders = new List<Order>();
        }

        [JsonProperty("store_id")]
        public string StoreId { get; set; }

        [JsonProperty("orders")]
        public IList<Order> Orders { get; set; }
    }
}
