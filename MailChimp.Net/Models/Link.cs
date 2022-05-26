// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Link.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using MailChimp.Net.Core;
using Newtonsoft.Json;
using System.Diagnostics;

namespace MailChimp.Net.Models
{
    /// <summary>
    /// The link.
    /// </summary>
    public class Link : Base
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
        [JsonConverter(typeof(StringEnumDescriptionConverter))]
        public Method Method { get; set; }

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

        internal override DisplayBuilder GetDebuggerDisplayBuilder(DisplayBuilder Builder) {
            return base.GetDebuggerDisplayBuilder(Builder)
                .Prefix.Add(Method)
                .Data.Add(Href)
                ;
        }
    }
}