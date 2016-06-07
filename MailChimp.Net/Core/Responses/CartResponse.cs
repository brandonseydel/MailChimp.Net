using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailChimp.Net.Models;
using Newtonsoft.Json;

namespace MailChimp.Net.Core
{
    public class CartResponse
    {
        public CartResponse()
        {
            this.Carts = new List<Cart>();
            this.Links = new List<Link>();
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
