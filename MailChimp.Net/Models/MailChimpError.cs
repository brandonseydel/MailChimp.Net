using System.Collections.Generic;
using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    public class MailChimpApiError
    {
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("status")]
        public int Status { get; set; }
        [JsonProperty("detail")]
        public string Detail { get; set; }
        [JsonProperty("instance")]
        public string Instance { get; set; }
        [JsonProperty("errors")]
        public List<MailChimpError> Errors { get; set; } = new List<MailChimpError>();
    }

    public class MailChimpError
    {
        [JsonProperty("field")]
        public string Field { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }
    }
}
