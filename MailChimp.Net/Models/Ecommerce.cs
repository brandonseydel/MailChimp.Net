using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    public class Ecommerce
    {

        [JsonProperty("total_orders")]
        public int TotalOrders { get; set; }

        [JsonProperty("total_spent")]
        public decimal TotalSpent { get; set; }

        [JsonProperty("total_revenue")]
        public decimal TotalRevenue { get; set; }
    }
}
