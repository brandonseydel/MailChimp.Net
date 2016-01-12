using System.Collections.Generic;
using MailChimp.Net.Models;
using Newtonsoft.Json;

namespace MailChimp.Net.Core
{
    public class ReportResponse
    {
        public ReportResponse()
        {
            Reports = new HashSet<Report>();
            Links = new HashSet<Link>();
        }


        [JsonProperty("reports")]
        public IEnumerable<Report> Reports { get; set; }

        [JsonProperty("_links")]
        public IEnumerable<Link> Links { get; set; }

        [JsonProperty("total_items")]
        public int TotalItems { get; set; }
    }
}