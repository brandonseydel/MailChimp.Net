using MailChimp.Net.Core;

namespace MailChimp.Net.Models;

public class Ecommerce
{

    [MailChimpJsonProperty("total_orders")]
    public int TotalOrders { get; set; }

    [MailChimpJsonProperty("total_spent")]
    public decimal TotalSpent { get; set; }

    [MailChimpJsonProperty("total_revenue")]
    public decimal TotalRevenue { get; set; }
}
