// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ApiResponse.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
using Newtonsoft.Json;
using System.Diagnostics;

namespace MailChimp.Net.Models
{
    /// <summary>
    /// The ping response
    /// </summary>
    public class Ping : Base
    {      

        /// <summary>
        /// Gets the health status from Mail Chimp
        /// </summary>
        [JsonProperty("health_status")]
        public string HealthStatus { get; set; }

        internal override DisplayBuilder GetDebuggerDisplayBuilder(DisplayBuilder Builder) {
            return base.GetDebuggerDisplayBuilder(Builder)
                .Data.Add(HealthStatus)
                ;
        }
    }
}