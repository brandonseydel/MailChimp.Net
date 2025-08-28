using System.Collections.Generic;
using MailChimp.Net.Models;
using Newtonsoft.Json;

namespace MailChimp.Net.Core;

public class CartLineResponse
{

    public CartLineResponse()
    {
        Lines = new List<Line>();
        Links = new List<Link>();
    }

    [JsonProperty("store_id")]
    public string StoreId { get; set; }

    [JsonProperty("cart_id")]
    public string CartId { get; set; }

    [JsonProperty("lines")]
    public ICollection<Line> Lines { get; set; }

    [JsonProperty("total_items")]
    public int TotalItems { get; set; }

    [JsonProperty("_links")]
    public ICollection<Link> Links { get; set; }
}
