using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    public class Line
    {
        [JsonProperty("product_id")]
        public string ProductId { get; set; }

        [JsonProperty("product_title")]
        public string ProductTitle { get; set; }

        [JsonProperty("product_variant_id")]
        public string ProductVariantId { get; set; }

        [JsonProperty("product_variant_title")]
        public string ProductVariantTitle { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        [JsonProperty("price")]
        public int Price { get; set; }
    }
}
