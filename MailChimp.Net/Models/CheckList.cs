// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CheckList.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using Newtonsoft.Json;
using System.Diagnostics;

namespace MailChimp.Net.Models
{
    /// <summary>
    /// The check list.
    /// </summary>
    public class CheckList : Base
    {
        /// <summary>
        /// Gets or sets the details.
        /// </summary>
        [JsonProperty("details")]
        public string Details { get; set; }

        /// <summary>
        /// Gets or sets the heading.
        /// </summary>
        [JsonProperty("heading")]
        public string Heading { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        [JsonProperty("type")]
        public Core.Result Type { get; set; }

        internal override DisplayBuilder GetDebuggerDisplayBuilder(DisplayBuilder Builder) {
            return base.GetDebuggerDisplayBuilder(Builder)
                .Type.Add(Type)
                .Data.Add(Heading)
                ;
        }

    }
}