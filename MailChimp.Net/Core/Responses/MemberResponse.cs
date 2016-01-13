using System.Collections.Generic;
using MailChimp.Net.Models;
using Newtonsoft.Json;

namespace MailChimp.Net.Core
{
    public class MemberResponse : BaseResponse
    {
        public MemberResponse()
        {
            Members = new HashSet<Member>();
        }

        [JsonProperty("members")]
        public IEnumerable<Member> Members { get; set; }

        [JsonProperty("list_id")]
        public string ListId { get; set; }

    }
}


