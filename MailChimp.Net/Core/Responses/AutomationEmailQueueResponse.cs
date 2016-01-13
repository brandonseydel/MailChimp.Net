using System.Collections.Generic;
using MailChimp.Net.Models;
using Newtonsoft.Json;

namespace MailChimp.Net.Core
{
    public class AutomationEmailQueueResponse : BaseResponse
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

    }
}