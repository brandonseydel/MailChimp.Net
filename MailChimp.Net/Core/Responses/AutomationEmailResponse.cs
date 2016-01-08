using System.Collections.Generic;
using MailChimp.Net.Models;
using Newtonsoft.Json;

namespace MailChimp.Net.Core
{
    public class AutomationEmailResponse
    {
        public AutomationEmailResponse()
        {
            Links = new HashSet<Link>();
            Emails = new HashSet<Email>();
        }

        [JsonProperty("workflow_id")]
        public string WorkflowId { get; set; }

        [JsonProperty("emails")]
        public IEnumerable<Email> Emails { get; set; }

        [JsonProperty("total_items")]
        public int TotalItems { get; set; }

        [JsonProperty("_links")]
        public IEnumerable<Link> Links { get; set; }
    }
}