using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    public class Goal
    {

        [JsonProperty("goal_id")]
        public int GoalId { get; set; }

        [JsonProperty("event")]
        public string Event { get; set; }

        [JsonProperty("last_visited_at")]
        public string LastVisitedAt { get; set; }

        [JsonProperty("data")]
        public string Data { get; set; }
    }
}
