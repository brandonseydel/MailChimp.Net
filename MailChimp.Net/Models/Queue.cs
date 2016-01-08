using System.Collections.Generic;
using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    public class Queue
    {
        public Queue()
        {
            Links = new HashSet<Link>();
        }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("workflow_id")]
        public string WorkflowId { get; set; }

        [JsonProperty("email_id")]
        public string EmailId { get; set; }

        [JsonProperty("list_id")]
        public string ListId { get; set; }

        [JsonProperty("next_send")]
        public string NextSend { get; set; }

        [JsonProperty("email_address")]
        public string EmailAddress { get; set; }

        [JsonProperty("_links")]
        public IEnumerable<Link> Links { get; set; }
    }
}