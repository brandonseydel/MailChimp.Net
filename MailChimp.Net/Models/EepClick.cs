// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EepClick.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;

using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    /// <summary>
    /// The eep click.
    /// </summary>
    public class EepClick
    {
        /// <summary>
        /// Gets or sets the clicks.
        /// </summary>
        public int Clicks { get; set; }

        /// <summary>
        /// Gets or sets the first click.
        /// </summary>
        [JsonProperty("first_click")]
        public string FirstClick { get; set; }

        /// <summary>
        /// Gets or sets the last click.
        /// </summary>
        [JsonProperty("last_click")]
        public string LastClick { get; set; }

        /// <summary>
        /// Gets or sets the locations.
        /// </summary>
        public IEnumerable<EepLocation> Locations { get; set; }
    }
}