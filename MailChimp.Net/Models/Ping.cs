// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ApiResponse.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    /// <summary>
    /// The ping response
    /// </summary>
    public class Ping
    {      

        /// <summary>
        /// Gets the health status from Mail Chimp
        /// </summary>
        [JsonProperty("health_status")]
        public string HealthStatus { get; set; }
    }
}