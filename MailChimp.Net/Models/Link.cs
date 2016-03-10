// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Link.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    /// <summary>
    /// The link.
    /// </summary>
    public class Link
    {
        /// <summary>
        /// Gets or sets the href.
        /// </summary>
        [JsonProperty("href")]
        public string Href { get; set; }

        /// <summary>
        /// Gets or sets the method.
        /// </summary>
        [JsonProperty("method")]
        public string Method { get; set; }

        /// <summary>
        /// Gets or sets the rel.
        /// </summary>
        [JsonProperty("rel")]
        public string Rel { get; set; }

        /// <summary>
        /// Gets or sets the schema.
        /// </summary>
        [JsonProperty("schema")]
        public string Schema { get; set; }

        /// <summary>
        /// Gets or sets the target schema.
        /// </summary>
        [JsonProperty("targetSchema")]
        public string TargetSchema { get; set; }
    }
}