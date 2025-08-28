using System.Collections.Generic;
using MailChimp.Net.Models;
using Newtonsoft.Json;

namespace MailChimp.Net.Core
{
    public class CartResponse
    {
        [JsonProperty("store_id")]
        public string StoreId { get; set; }

        [JsonProperty("carts")]
        public IList<Cart> Carts { get; set; } = new List<Cart>();

        [JsonProperty("total_items")]
        public int TotalItems { get; set; }

        [JsonProperty("_links")]
        public IList<Link> Links { get; set; } = new List<Link>();
    }
}
