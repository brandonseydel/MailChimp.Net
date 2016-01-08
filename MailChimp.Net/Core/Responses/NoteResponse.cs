using System.Collections.Generic;
using MailChimp.Net.Models;
using Newtonsoft.Json;

namespace MailChimp.Net.Core
{
        public class NoteResponse
        {
            public NoteResponse()
            {
                Notes = new HashSet<Note>();
                Links = new HashSet<Link>();
            }

            [JsonProperty("notes")]
            public IEnumerable<Note> Notes { get; set; }

            [JsonProperty("email_id")]
            public string EmailId { get; set; }

            [JsonProperty("list_id")]
            public string ListId { get; set; }

            [JsonProperty("_links")]
            public IEnumerable<Link> Links { get; set; }

            [JsonProperty("total_items")]
            public int TotalItems { get; set; }
        }

    

}