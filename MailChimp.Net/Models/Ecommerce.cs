using Newtonsoft.Json;
using System.Diagnostics;

namespace MailChimp.Net.Models
{
    public class Ecommerce : Base
    {

        [JsonProperty("total_orders")]
        public int TotalOrders { get; set; }

        [JsonProperty("total_spent")]
        public decimal TotalSpent { get; set; }

        [JsonProperty("total_revenue")]
        public decimal TotalRevenue { get; set; }

        internal override DisplayBuilder GetDebuggerDisplayBuilder(DisplayBuilder Builder) {
            return base.GetDebuggerDisplayBuilder(Builder)
                .Data.AddExpression(TotalRevenue)
                ;
        }
    }
}
