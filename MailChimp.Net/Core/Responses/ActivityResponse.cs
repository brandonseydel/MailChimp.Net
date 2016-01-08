using System.Collections.Generic;
using MailChimp.Net.Models;
using Newtonsoft.Json;

namespace MailChimp.Net.Core
{
    public class ActivityResponse
    {
        public ActivityResponse()
        {
            Activity = new HashSet<Activity>();
        }

        [JsonProperty("activity")]
        public IEnumerable<Activity> Activity { get; set; }

        [JsonProperty("email_id")]
        public string EmailId { get; set; }

        [JsonProperty("list_id")]
        public string ListId { get; set; }

        [JsonProperty("_links")]
        public Link[] Links { get; set; }

        [JsonProperty("total_items")]
        public int TotalItems { get; set; }
    }
}