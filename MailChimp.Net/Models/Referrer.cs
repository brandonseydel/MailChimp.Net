// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Referrer.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System;
using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    /// <summary>
    /// The referrer.
    /// </summary>
    public class Referrer
    {
        /// <summary>
        /// Gets or sets the clicks.
        /// </summary>
        [JsonProperty("clicks")]
        public int Clicks { get; set; }

        /// <summary>
        /// Gets or sets the first click.
        /// </summary>
        [JsonProperty("first_click")]
        public DateTime? FirstClick { get; set; }

        /// <summary>
        /// Gets or sets the last click.
        /// </summary>
        [JsonProperty("last_click")]
        public DateTime? LastClick { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        [JsonProperty("referrer")]
        public string Name { get; set; }
    }
}