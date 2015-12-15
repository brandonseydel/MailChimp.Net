using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    internal class Message
    {

        [JsonProperty("from_label")]
        public string FromLabel { get; set; }

        [JsonProperty("from_email")]
        public string FromEmail { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("message")]
        public string Body { get; set; }

        [JsonProperty("read")]
        public bool Read { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }
}