using System.Collections.Generic;
using MailChimp.Net.Models;
using Newtonsoft.Json;

namespace MailChimp.Net.Core
{
    public class NoteResponse : BaseResponse
    {
        public NoteResponse()
        {
            Notes = new HashSet<Note>();
        }

        [JsonProperty("notes")]
        public IEnumerable<Note> Notes { get; set; }

        [JsonProperty("email_id")]
        public string EmailId { get; set; }

        [JsonProperty("list_id")]
        public string ListId { get; set; }
    }
}