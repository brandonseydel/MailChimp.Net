using Newtonsoft.Json;

namespace MailChimp.Net.Core.Responses
{
    /// <summary>A member event response.</summary>
    /// <seealso cref="BaseResponse"/>
    public class MemberEventResponse : BaseResponse
    {
        /// <summary>Gets or sets the events.</summary>
        /// <value>The events.</value>
        [JsonProperty("events")]
        public MemberEvent[] Events { get; set; }
    }
}
