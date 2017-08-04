// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Goal.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    /// <summary>
    /// The goal.
    /// </summary>
    public class Goal
    {
        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        [JsonProperty("data")]
        public string Data { get; set; }

        /// <summary>
        /// Gets or sets the event.
        /// </summary>
        [JsonProperty("event")]
        public string Event { get; set; }

        /// <summary>
        /// Gets or sets the goal id.
        /// </summary>
        [JsonProperty("goal_id")]
        public int GoalId { get; set; }

        /// <summary>
        /// Gets or sets the last visited at.
        /// </summary>
        [JsonProperty("last_visited_at")]
        public string LastVisitedAt { get; set; }
    }
}