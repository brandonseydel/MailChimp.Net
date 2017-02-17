using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailChimp.Net.Models
{
    public class Ecommerce
    {

        [JsonProperty("total_orders")]
        public int TotalOrders { get; set; }

        [JsonProperty("total_spent")]
        public double TotalSpent { get; set; }

        [JsonProperty("total_revenue")]
        public double TotalRevenue { get; set; }
    }
}
