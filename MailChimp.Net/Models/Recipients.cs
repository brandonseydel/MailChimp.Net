using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    internal class Recipients
    {

        [JsonProperty("list_id")]
        public string ListId { get; set; }

        [JsonProperty("segment_text")]
        public string SegmentText { get; set; }
    }
}