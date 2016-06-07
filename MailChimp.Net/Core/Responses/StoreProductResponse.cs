using System;
using System.Collections.Generic;
using MailChimp.Net.Models;
using Newtonsoft.Json;

namespace MailChimp.Net.Core
{
    public class StoreProductResponse : BaseResponse
    {

        public StoreProductResponse()
        {
            this.Products = new List<Product>();
        }
        [JsonProperty("store_id")]
        public string StoreId { get; set; }

        [JsonProperty("products")]
        public IList<Product> Products { get; set; }
    }
}
