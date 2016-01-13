using System.Collections.Generic;
using MailChimp.Net.Models;
using Newtonsoft.Json;

namespace MailChimp.Net.Core
{
    public class MessageResponse : BaseResponse
    {
        public MessageResponse()
        {
            Messages = new HashSet<Message>();
        }

        [JsonProperty("conversation_messages")]
        public IEnumerable<Message> Messages { get; set; }
    }
}