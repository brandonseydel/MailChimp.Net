using System.Collections.Generic;
using Newtonsoft.Json;
using MailChimp.Net.Core;

namespace MailChimp.Net.Models
{
    public class Order
    {

        public Order()
        {
            this.Lines = new List<Line>();
            this.Links = new List<Link>();
        }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("customer")]
        public Customer Customer { get; set; }

        [JsonProperty("campaign_id")]
        public string CampaignId { get; set; }

        [JsonProperty("financial_status")]
        public string FinancialStatus { get; set; }

        [JsonProperty("fulfillment_status")]
        public string FulfillmentStatus { get; set; }

        [JsonProperty("currency_code")]
        [JsonConverter(typeof(StringEnumDescriptionConverter))]
        public CurrencyCode CurrencyCode { get; set; }

        [JsonProperty("order_total")]
        public double OrderTotal { get; set; }

        [JsonProperty("tax_total")]
        public double TaxTotal { get; set; }

        [JsonProperty("shipping_total")]
        public double ShippingTotal { get; set; }

        [JsonProperty("tracking_code")]
        public string TrackingCode { get; set; }

        [JsonProperty("processed_at_foreign")]
        public string ProcessedAtForeign { get; set; }

        [JsonProperty("cancelled_at_foreign")]
        public string CancelledAtForeign { get; set; }

        [JsonProperty("shipping_address")]
        public Address ShippingAddress { get; set; }

        [JsonProperty("billing_address")]
        public Address BillingAddress { get; set; }


        [JsonProperty("updated_at_foreign")]
        public string UpdatedAtForeign { get; set; }

        [JsonProperty("lines")]
        public IList<Line> Lines { get; set; }

        [JsonProperty("_links")]
        public IList<Link> Links { get; set; }
    }
}
