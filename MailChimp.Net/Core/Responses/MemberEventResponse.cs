using Newtonsoft.Json;

namespace MailChimp.Net.Core.Responses
{
    public class MemberEventResponse : BaseResponse
    {
        [JsonProperty("events")]
        public MemberEvent[] Events { get; set; }
    }
}
