using System.Collections.Generic;
using MailChimp.Net.Models;
using Newtonsoft.Json;

namespace MailChimp.Net.Core
{
    public class AutomationEmailQueueResponse
    {
        public AutomationEmailQueueResponse()
        {
            this.Queues = new HashSet<Queue>();
            Links = new HashSet<Link>();
        }
        [JsonProperty("workflow_id")]
        public string WorkflowId { get; set; }

        [JsonProperty("email_id")]
        public string EmailId { get; set; }

        [JsonProperty("queue")]
        public IEnumerable<Queue> Queues { get; set; }

        [JsonProperty("total_items")]
        public int TotalItems { get; set; }

        [JsonProperty("_links")]
        public IEnumerable<Link> Links { get; set; }
    }
}