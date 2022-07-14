using Newtonsoft.Json;

namespace MailChimp.Net.Core.Responses
{
    public class MemberEvent
    {
        [JsonProperty("occurred_at")]
        public string OccurredAt { get; set; }

        [JsonProperty("name")]
        public string EventName { get; set; }

        [JsonProperty("properties")]
        public object EventProperties { get; set; }
    }
}
