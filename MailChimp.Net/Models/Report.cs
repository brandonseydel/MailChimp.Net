using System.Collections.Generic;
using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    public class Report
    {
        public Report()
        {
            Timeseries = new HashSet<Timesery>();
            Links = new HashSet<Link>();
        }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("campaign_title")]
        public string CampaignTitle { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("emails_sent")]
        public int EmailsSent { get; set; }

        [JsonProperty("abuse_reports")]
        public int AbuseReports { get; set; }

        [JsonProperty("unsubscribed")]
        public int Unsubscribed { get; set; }

        [JsonProperty("send_time")]
        public string SendTime { get; set; }

        [JsonProperty("bounces")]
        public Bounces Bounces { get; set; }

        [JsonProperty("forwards")]
        public Forwards Forwards { get; set; }

        [JsonProperty("opens")]
        public Opens Opens { get; set; }

        [JsonProperty("clicks")]
        public Clicks Clicks { get; set; }

        [JsonProperty("facebook_likes")]
        public FacebookLikes FacebookLikes { get; set; }

        [JsonProperty("industry_stats")]
        public IndustryStats IndustryStats { get; set; }

        [JsonProperty("list_stats")]
        public ListStats ListStats { get; set; }

        [JsonProperty("timeseries")]
        public IEnumerable<Timesery> Timeseries { get; set; }

        [JsonProperty("share_report")]
        public ShareReport ShareReport { get; set; }

        [JsonProperty("delivery_status")]
        public DeliveryStatus DeliveryStatus { get; set; }

        [JsonProperty("_links")]
        public IEnumerable<Link> Links { get; set; }
    }
}