using System.Collections.Generic;
using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    public class Email
    {
        public Email()
        {
            Links = new HashSet<Link>();
        }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("workflow_id")]
        public string WorkflowId { get; set; }

        [JsonProperty("position")]
        public int Position { get; set; }

        [JsonProperty("delay")]
        public Delay Delay { get; set; }

        [JsonProperty("create_time")]
        public string CreateTime { get; set; }

        [JsonProperty("start_time")]
        public string StartTime { get; set; }

        [JsonProperty("archive_url")]
        public string ArchiveUrl { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("emails_sent")]
        public int EmailsSent { get; set; }

        [JsonProperty("send_time")]
        public string SendTime { get; set; }

        [JsonProperty("content_type")]
        public string ContentType { get; set; }

        [JsonProperty("recipients")]
        public Recipient Recipients { get; set; }

        [JsonProperty("settings")]
        public Setting Settings { get; set; }

        [JsonProperty("tracking")]
        public Tracking Tracking { get; set; }

        [JsonProperty("report_summary")]
        public ReportSummary ReportSummary { get; set; }

        [JsonProperty("_links")]
        public IEnumerable<Link> Links { get; set; }
    }
}