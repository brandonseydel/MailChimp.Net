// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TimeStamp.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using Newtonsoft.Json;

using System;
using System.Diagnostics;

namespace MailChimp.Net.Models
{
    /// <summary>
    /// The TimeStamp.
    /// </summary>
    public class TimeStamp : Base
    {

        /// <summary>
        /// Gets or sets the Timestamp.
        /// </summary>
        [JsonProperty("timestamp")]
        public DateTime Timestamp { get; set; }

        internal override DisplayBuilder GetDebuggerDisplayBuilder(DisplayBuilder Builder) {
            return base.GetDebuggerDisplayBuilder(Builder)
                .Data.Add(Timestamp)
                ;
        }
    }
}
