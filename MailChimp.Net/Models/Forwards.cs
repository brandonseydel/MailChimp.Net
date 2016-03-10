// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Forwards.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    /// <summary>
    /// The forwards.
    /// </summary>
    public class Forwards
    {
        /// <summary>
        /// Gets or sets the forwards count.
        /// </summary>
        [JsonProperty("forwards_count")]
        public int ForwardsCount { get; set; }

        /// <summary>
        /// Gets or sets the forwards opens.
        /// </summary>
        [JsonProperty("forwards_opens")]
        public int ForwardsOpens { get; set; }
    }
}