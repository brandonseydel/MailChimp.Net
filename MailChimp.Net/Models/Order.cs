using System.Collections.Generic;
using MailChimp.Net.Core;
using System;

namespace MailChimp.Net.Models;

public class Order
{

    public Order()
    {
        Lines = new List<Line>();
        Links = new List<Link>();
        Promos = new List<Promo>();
    }

    [MailChimpJsonProperty("id")]
    public string Id { get; set; }

    [MailChimpJsonProperty("customer")]
    public Customer Customer { get; set; }

    [MailChimpJsonProperty("store_id")]
    public string StoreId { get; set; }

    [MailChimpJsonProperty("campaign_id")]
    public string CampaignId { get; set; }

    [MailChimpJsonProperty("landing_site")]
    public string LandingSite { get; set; }

    [MailChimpJsonProperty("financial_status")]
    public string FinancialStatus { get; set; }

    [MailChimpJsonProperty("fulfillment_status")]
    public string FulfillmentStatus { get; set; }

    [MailChimpJsonProperty("currency_code")]
    [MailChimpJsonConverter(MailChimpJsonConverterKind.StringEnumDescription)]
    public CurrencyCode CurrencyCode { get; set; }

    [MailChimpJsonProperty("order_total")]
    public decimal OrderTotal { get; set; }

    [MailChimpJsonProperty("order_url")]
    public string OrderUrl { get; set; }

    [MailChimpJsonProperty("discount_total")]
    public decimal? DiscountTotal { get; set; }

    [MailChimpJsonProperty("tax_total")]
    public decimal? TaxTotal { get; set; }

    [MailChimpJsonProperty("shipping_total")]
    public decimal? ShippingTotal { get; set; }

    [MailChimpJsonProperty("tracking_code")]
    public string TrackingCode { get; set; }

    [MailChimpJsonProperty("processed_at_foreign")]
    public string ProcessedAtForeign { get; set; }

    [MailChimpJsonProperty("cancelled_at_foreign")]
    public string CancelledAtForeign { get; set; }

    [MailChimpJsonProperty("shipping_address")]
    public OrderAddress ShippingAddress { get; set; }

    [MailChimpJsonProperty("billing_address")]
    public OrderAddress BillingAddress { get; set; }

    [MailChimpJsonProperty("created_at")]
    public DateTime? CreatedAt { get; set; }

    [MailChimpJsonProperty("updated_at")]
    public DateTime? UpdatedAt { get; set; }

    [MailChimpJsonProperty("updated_at_foreign")]
    public DateTime? UpdatedAtForeign { get; set; }

    [MailChimpJsonProperty("promos")]
    public IList<Promo> Promos { get; set; }

    [MailChimpJsonProperty("lines")]
    public IList<Line> Lines { get; set; }
    
    [MailChimpJsonProperty("outreach")]
    public Outreach Outreach { get; set; }

    [MailChimpJsonProperty("_links")]
    public IList<Link> Links { get; set; }
}
