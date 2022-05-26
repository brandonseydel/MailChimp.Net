using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using MailChimp.Net.Core;
using System.Diagnostics;

namespace MailChimp.Net.Models
{
    public class Cart : Base, IId<string>
    {
        public Cart()
        {
            Lines = new HashSet<Line>();
            Links = new HashSet<Link>();
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
        [JsonConverter(typeof(StringEnumDescriptionConverter))]
        public CurrencyCode CurrencyCode { get; set; }

        [JsonProperty("order_total")]
        public decimal? OrderTotal { get; set; }

        [JsonProperty("tax_total")]
        public decimal? TaxTotal { get; set; }

        [JsonProperty("lines")]
        public ICollection<Line> Lines { get; set; }

        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt { get; set; }

        [JsonProperty("_links")]
        public ICollection<Link> Links { get; set; }

        internal override DisplayBuilder GetDebuggerDisplayBuilder(DisplayBuilder Builder) {
            return base.GetDebuggerDisplayBuilder(Builder)
                .Id.Add(Id)
                .Data.Add(CheckoutUrl)
                .Postfix.Add(OrderTotal)
                ;
        }
    }
}
