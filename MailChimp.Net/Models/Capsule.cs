using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    public class Capsule : Base
    {
        [JsonProperty("notes")]
        public bool UpdateNotesForCampaign { get; set; }
    }
}