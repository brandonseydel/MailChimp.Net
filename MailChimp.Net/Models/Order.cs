using System.Collections.Generic;
using Newtonsoft.Json;
using MailChimp.Net.Core;

namespace MailChimp.Net.Models
{
    public class Order
    {

        public Order()
        {
            Lines = new List<Line>();
            Links = new List<Link>();
            Promos = new List<Promo>();
        }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("customer")]
        public Customer Customer { get; set; }

        [JsonProperty("store_id")]
        public string StoreId { get; set; }

        [JsonProperty("campaign_id")]
        public string CampaignId { get; set; }

        [JsonProperty("landing_site")]
        public string LandingSite { get; set; }

        [JsonProperty("financial_status")]
        public string FinancialStatus { get; set; }

        [JsonProperty("fulfillment_status")]
        public string FulfillmentStatus { get; set; }

        [JsonProperty("currency_code")]
        [JsonConverter(typeof(StringEnumDescriptionConverter))]
        public CurrencyCode CurrencyCode { get; set; }

        [JsonProperty("order_total")]
        public decimal OrderTotal { get; set; }

        [JsonProperty("order_url")]
        public string OrderUrl { get; set; }

        [JsonProperty("discount_total")]
        public decimal? DiscountTotal { get; set; }

        [JsonProperty("tax_total")]
        public decimal? TaxTotal { get; set; }

        [JsonProperty("shipping_total")]
        public decimal? ShippingTotal { get; set; }

        [JsonProperty("tracking_code")]
        public string TrackingCode { get; set; }

        [JsonProperty("processed_at_foreign")]
        public string ProcessedAtForeign { get; set; }

        [JsonProperty("cancelled_at_foreign")]
        public string CancelledAtForeign { get; set; }

        [JsonProperty("shipping_address")]
        public OrderAddress ShippingAddress { get; set; }

        [JsonProperty("billing_address")]
        public OrderAddress BillingAddress { get; set; }

        [JsonProperty("updated_at_foreign")]
        public string UpdatedAtForeign { get; set; }

        [JsonProperty("promos")]
        public IList<Promo> Promos { get; set; }

        [JsonProperty("lines")]
        public IList<Line> Lines { get; set; }
        
        [JsonProperty("outreach")]
        public Outreach Outreach { get; set; }

        [JsonProperty("_links")]
        public IList<Link> Links { get; set; }
    }
}
