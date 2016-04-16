// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SegmentOpts.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;
using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    /// <summary>
    /// The segment opts.
    /// </summary>
    public class SegmentOptions
    {

        public SegmentOptions()
        {
            Conditions = new HashSet<Condition>();
        }

        /// <summary>
        /// Gets or sets the conditions.
        /// </summary>
        [JsonProperty("conditions")]
        public IEnumerable<Condition> Conditions { get; set; }

        /// <summary>
        /// Gets or sets the match.
        /// </summary>
        [JsonProperty("match")]
        public string Match { get; set; }

        /// <summary>
        /// Gets or sets the saved segment id.
        /// </summary>
        [JsonProperty("saved_segment_id")]
        public int SavedSegmentId { get; set; }
    }
}