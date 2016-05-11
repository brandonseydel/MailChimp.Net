using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailChimp.Net.Models
{
    public class MemberStats
    {
        [JsonProperty("avg_open_rate")]
        public int AverageOpenRate { get; set; }
        [JsonProperty("avg_click_rate")]
        public int AverageClickRate { get; set; }
    }
}
