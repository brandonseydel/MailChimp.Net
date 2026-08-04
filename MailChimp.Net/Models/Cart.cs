using System;
using System.Collections.Generic;
using MailChimp.Net.Core;

namespace MailChimp.Net.Models;

public class Cart
{
    public Cart()
    {
        Lines = new HashSet<Line>();
        Links = new HashSet<Link>();
    }

    [MailChimpJsonProperty("id")]
    public string Id { get; set; }

    [MailChimpJsonProperty("customer")]
    public Customer Customer { get; set; }

    [MailChimpJsonProperty("campaign_id")]
    public string CampaignId { get; set; }

    [MailChimpJsonProperty("checkout_url")]
    public string CheckoutUrl { get; set; }

    [MailChimpJsonProperty("currency_code")]
    [MailChimpJsonConverter(MailChimpJsonConverterKind.StringEnumDescription)]
    public CurrencyCode CurrencyCode { get; set; }

    [MailChimpJsonProperty("order_total")]
    public decimal? OrderTotal { get; set; }

    [MailChimpJsonProperty("tax_total")]
    public decimal? TaxTotal { get; set; }

    [MailChimpJsonProperty("lines")]
    public ICollection<Line> Lines { get; set; }

    [MailChimpJsonProperty("created_at")]
    public DateTime? CreatedAt { get; set; }

    [MailChimpJsonProperty("updated_at")]
    public DateTime? UpdatedAt { get; set; }

    [MailChimpJsonProperty("_links")]
    public ICollection<Link> Links { get; set; }
}
