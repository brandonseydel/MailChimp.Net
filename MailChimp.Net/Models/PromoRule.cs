using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using Newtonsoft.Json;

namespace MailChimp.Net.Models;

public class PromoRule
{
    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("title")]
    public string Title { get; set; }

    [JsonProperty("description")]
    public string Description { get; set; }

    [JsonProperty("starts_at")]
    public DateTime? StartsAt { get; set; }

    [JsonProperty("ends_at")]
    public DateTime? EndsAt { get; set; }

    [JsonProperty("amount")]
    public decimal Amount { get; set; }
    
    [JsonProperty("type")]
    [JsonConverter(typeof(StringEnumDescriptionConverter))]
    public PromoType Type { get; set; }

    [JsonProperty("target")]
    [JsonConverter(typeof(StringEnumDescriptionConverter))]
    public PromoTarget Target { get; set; }

    [JsonProperty("enabled")]
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
