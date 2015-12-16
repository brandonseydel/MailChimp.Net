using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    public class SegmentOpts
    {

        [JsonProperty("saved_segment_id")]
        public int SavedSegmentId { get; set; }

        [JsonProperty("match")]
        public string Match { get; set; }

        [JsonProperty("conditions")]
        public Condition[] Conditions { get; set; }
    }
}
