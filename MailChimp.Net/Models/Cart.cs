using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    public class Cart
    {

        public Cart()
        {
            this.Lines = new HashSet<Line>();
            this.Links = new HashSet<Link>();
        }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("customer")]
        public Customer Customer { get; set; }

        [JsonProperty("campaign_id")]
        public string CampaignId { get; set; }

        [JsonProperty("checkout_url")]
        public string CheckoutUrl { get; set; }

        [JsonProperty("currency_code")]
        public string CurrencyCode { get; set; }

        [JsonProperty("order_total")]
        public double OrderTotal { get; set; }

        [JsonProperty("tax_total")]
        public double TaxTotal { get; set; }

        [JsonProperty("lines")]
        public ICollection<Line> Lines { get; set; }

        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt { get; set; }

        [JsonProperty("_links")]
        public ICollection<Link> Links { get; set; }
    }
}
