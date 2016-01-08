using System.Collections.Generic;
using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    public class Subscriber
    {
        public Subscriber()
        {
            Links = new HashSet<Link>();
        }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("workflow_id")]
        public string WorkflowId { get; set; }

        [JsonProperty("list_id")]
        public string ListId { get; set; }

        [JsonProperty("email_address")]
        public string EmailAddress { get; set; }

        [JsonProperty("_links")]
        public IEnumerable<Link> Links { get; set; }
    }
}

}