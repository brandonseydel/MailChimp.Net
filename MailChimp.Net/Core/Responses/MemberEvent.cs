using Newtonsoft.Json;

namespace MailChimp.Net.Core.Responses
{
    /// <summary>A member event.</summary>
    public class MemberEvent
    {
        /// <summary>Gets or sets the occurred at.</summary>
        /// <value>The occurred at.</value>
        [JsonProperty("occurred_at")]
        public string OccurredAt { get; set; }

        /// <summary>Gets or sets the name of the event.</summary>
        /// <value>The name of the event.</value>
        [JsonProperty("name")]
        public string EventName { get; set; }

        /// <summary>Gets or sets the event properties.</summary>
        /// <value>The event properties.</value>
        [JsonProperty("properties")]
        public object EventProperties { get; set; }
    }
}
