using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    public class Capsule
    {
        [JsonProperty("notes")]
        public bool UpdateNotesForCampaign { get; set; }
    }
}