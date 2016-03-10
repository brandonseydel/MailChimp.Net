// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Condition.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    /// <summary>
    /// The condition.
    /// </summary>
    public class Condition
    {
        /// <summary>
        /// Gets or sets the field.
        /// </summary>
        [JsonProperty("field")]
        public string Field { get; set; }

        /// <summary>
        /// Gets or sets the op.
        /// </summary>
        [JsonProperty("op")]
        public string Op { get; set; }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        [JsonProperty("value")]
        public int Value { get; set; }
    }
}