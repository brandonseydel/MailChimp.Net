using System.Collections.Generic;
using MailChimp.Net.Models;
using Newtonsoft.Json;

namespace MailChimp.Net.Core
{
    public class ConversationResponse : BaseResponse
    {
        public ConversationResponse()
        {
            Conversations = new HashSet<Conversation>();
        }

        [JsonProperty("conversations")]
        public IEnumerable<Conversation> Conversations { get; set; }
    }
}


