using MailChimp.Net.Core;

namespace MailChimp.Net.Models;

public class EcommerceProductActivity
{
    [MailChimpJsonProperty("title")]
    public string Title { get; set; }

    [MailChimpJsonProperty("currency_code")]
    public string CurrencyCode { get; set; }

    [MailChimpJsonProperty("image_url")]
    public string ImageUrl { get; set; }

    [MailChimpJsonProperty("total_revenue")]
    public decimal TotalRevenue { get; set; }

    [MailChimpJsonProperty("total_purchased")]
    public int TotalPurchased { get; set; }

    [MailChimpJsonProperty("recommendation_total")]
    public int RecommendationTotal { get; set; }

    [MailChimpJsonProperty("recommendation_purchased")]
    public int RecommendationPurchased { get; set; }
}
