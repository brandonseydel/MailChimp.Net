using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailChimp.Net.Core;
namespace MailChimp.Net.Models;

public class PromoRule
{
    [MailChimpJsonProperty("id")]
    public string Id { get; set; }

    [MailChimpJsonProperty("title")]
    public string Title { get; set; }

    [MailChimpJsonProperty("description")]
    public string Description { get; set; }

    [MailChimpJsonProperty("starts_at")]
    public DateTime? StartsAt { get; set; }

    [MailChimpJsonProperty("ends_at")]
    public DateTime? EndsAt { get; set; }

    [MailChimpJsonProperty("amount")]
    public decimal Amount { get; set; }
    
    [MailChimpJsonProperty("type")]
    [MailChimpJsonConverter(MailChimpJsonConverterKind.StringEnumDescription)]
    public PromoType Type { get; set; }

    [MailChimpJsonProperty("target")]
    [MailChimpJsonConverter(MailChimpJsonConverterKind.StringEnumDescription)]
    public PromoTarget Target { get; set; }

    [MailChimpJsonProperty("enabled")]
    public bool Enabled { get; set; }
}

public enum PromoType
{
    [Description("fixed")]
    Fixed,
    [Description("percentage")]
    Percentage
}

public enum PromoTarget
{
    [Description("per_item")]
    PerItem,
    [Description("total")]
    Total,
    [Description("shipping")]
    Shipping
}
