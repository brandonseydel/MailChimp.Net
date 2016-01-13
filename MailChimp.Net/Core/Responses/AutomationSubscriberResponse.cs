using System.Collections.Generic;
using MailChimp.Net.Models;
using Newtonsoft.Json;

namespace MailChimp.Net.Core
{
    public class AutomationSubscriberResponse
    {
        public AutomationSubscriberResponse()
        {
            Subscribers = new HashSet<Subscriber>();
        }
        [JsonProperty("workflow_id")]
        public string WorkflowId { get; set; }

        [JsonProperty("subscribers")]
        public IEnumerable<Subscriber> Subscribers { get; set; }

        [JsonProperty("total_items")]
        public int TotalItems { get; set; }
    }
}
