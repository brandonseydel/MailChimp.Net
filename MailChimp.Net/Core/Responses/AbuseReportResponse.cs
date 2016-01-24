using System.Collections.Generic;
using MailChimp.Net.Models;
using Newtonsoft.Json;

namespace MailChimp.Net.Core
{
    public class AbuseReportResponse
    {
        public AbuseReportResponse()
        {
            AbuseReports = new HashSet<AbuseReport>();
            Links = new HashSet<Link>();
        }

        [JsonProperty("abuse_reports")]
        public IEnumerable<AbuseReport> AbuseReports { get; set; }

        [JsonProperty("list_id")]
        public string ListId { get; set; }

        [JsonProperty("total_items")]
        public int TotalItems { get; set; }

        [JsonProperty("_links")]
        public IEnumerable<Link> Links { get; set; }
    }
}