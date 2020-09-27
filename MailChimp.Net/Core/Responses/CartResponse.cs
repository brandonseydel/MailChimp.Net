using System.Collections.Generic;
using MailChimp.Net.Models;
using Newtonsoft.Json;

namespace MailChimp.Net.Core
{
    public class CartResponse
    {
        public CartResponse()
        {
            Carts = new List<Cart>();
            Links = new List<Link>();
        }

        [JsonProperty("store_id")]
        public string StoreId { get; set; }

        [JsonProperty("carts")]
        public IList<Cart> Carts { get; set; }

        [JsonProperty("total_items")]
        public int TotalItems { get; set; }

        [JsonProperty("_links")]
        public IList<Link> Links { get; set; }
    }
}
