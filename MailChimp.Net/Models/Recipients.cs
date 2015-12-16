using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    public class Recipient
    {

        [JsonProperty("list_id")]
        public string ListId { get; set; }

        [JsonProperty("segment_text")]
        public string SegmentText { get; set; }
    }
}