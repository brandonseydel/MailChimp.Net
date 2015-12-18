using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace MailChimp.Net.Models
{
    class Note
    {
        [JsonProperty("note_id")]
        public int Id { get; set; }

        [JsonProperty("created_at")]
        [JsonConverter(typeof(JavaScriptDateTimeConverter))]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("created_by")]
        public string CreatedBy { get; set; }

        [JsonProperty("note")]
        public string Body { get; set; }
    }
}
