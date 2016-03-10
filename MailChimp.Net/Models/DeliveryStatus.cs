// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DeliveryStatus.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    /// <summary>
    /// The delivery status.
    /// </summary>
    public class DeliveryStatus
    {
        /// <summary>
        /// Gets or sets a value indicating whether enabled.
        /// </summary>
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }
    }
}