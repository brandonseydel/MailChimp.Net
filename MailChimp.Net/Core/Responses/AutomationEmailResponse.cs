using System.Collections.Generic;
using MailChimp.Net.Models;
using Newtonsoft.Json;

namespace MailChimp.Net.Core
{
    public class AutomationEmailResponse : BaseResponse
    {
        public AutomationEmailResponse()
        {
            Emails = new HashSet<Email>();
        }

        [JsonProperty("workflow_id")]
        public string WorkflowId { get; set; }

        [JsonProperty("emails")]
        public IEnumerable<Email> Emails { get; set; }
    }
}