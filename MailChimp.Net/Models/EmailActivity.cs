using System.Collections.Generic;
using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    public class EmailActivity
    {
        public EmailActivity()
        {
            Activity = new HashSet<Activity>();
            Links = new HashSet<Link>();
        }

        [JsonProperty("campaign_id")]
        public string CampaignId { get; set; }

        [JsonProperty("list_id")]
        public string ListId { get; set; }

        [JsonProperty("email_id")]
        public string EmailId { get; set; }

        [JsonProperty("email_address")]
        public string EmailAddress { get; set; }

        [JsonProperty("activity")]
        public IEnumerable<Activity> Activity { get; set; }

        [JsonProperty("_links")]
        public IEnumerable<Link> Links { get; set; }
    }
}