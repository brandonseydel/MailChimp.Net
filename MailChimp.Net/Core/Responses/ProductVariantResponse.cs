using System.Collections.Generic;
using MailChimp.Net.Models;
using Newtonsoft.Json;

namespace MailChimp.Net.Core
{
    public class ProductVariantResponse : BaseResponse
    {

        public ProductVariantResponse()
        {
            this.Variants = new List<Variant>();
        }

        [JsonProperty("store_id")]
        public string StoreId { get; set; }

        [JsonProperty("product_id")]
        public string ProductId { get; set; }

        [JsonProperty("variants")]
        public IList<Variant> Variants { get; set; }
    }
}
