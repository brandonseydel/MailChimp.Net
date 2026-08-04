using MailChimp.Net.Core;

namespace MailChimp.Net.Models;

public class Promo
{
    [MailChimpJsonProperty("code")]
    public string Code { get; set; }

    [MailChimpJsonProperty("amount_discounted")]
    public decimal AmountDiscounted { get; set; }

    [MailChimpJsonProperty("type")]
    public string Type { get; set; }
}