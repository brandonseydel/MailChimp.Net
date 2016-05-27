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


        [JsonProperty("condition_type")]
        public string Type { get; set; }

        [JsonProperty("op")]
        public string Operator { get; set; }

        [JsonProperty("extra")]
        public string Extra { get; set; }
        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}