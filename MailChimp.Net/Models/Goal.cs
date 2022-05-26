// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Goal.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using Newtonsoft.Json;
using System.Diagnostics;

namespace MailChimp.Net.Models
{
    /// <summary>
    /// The goal.
    /// </summary>
    public class Goal : Base, IId<int>
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
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the last visited at.
        /// </summary>
        [JsonProperty("last_visited_at")]
        public string LastVisitedAt { get; set; }

        internal override DisplayBuilder GetDebuggerDisplayBuilder(DisplayBuilder Builder) {
            return base.GetDebuggerDisplayBuilder(Builder)
                .Id.Add(Id)
                .Prefix.Add(Event)
                .Data.Add(Data)
                ;
        }
    }
}