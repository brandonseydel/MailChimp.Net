using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    public class TriggerSettings
    {

        [JsonProperty("workflow_type")]
        public string WorkflowType { get; set; }

        [JsonProperty("send_immediately")]
        public bool SendImmediately { get; set; }

        [JsonProperty("trigger_on_import")]
        public bool TriggerOnImport { get; set; }

        [JsonProperty("runtime")]
        public Runtime Runtime { get; set; }

        [JsonProperty("workflow_emails_count")]
        public int WorkflowEmailsCount { get; set; }
    }
}