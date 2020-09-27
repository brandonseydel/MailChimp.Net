﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ListStats.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    /// <summary>
    /// The list stats.
    /// </summary>
    public class ListStats
    {
        /// <summary>
        /// Gets or sets the click rate.
        /// </summary>
        [JsonProperty("click_rate")]
        public double ClickRate { get; set; }

        /// <summary>
        /// Gets or sets the open rate.
        /// </summary>
        [JsonProperty("open_rate")]
        public double OpenRate { get; set; }

        /// <summary>
        /// Gets or sets the sub rate.
        /// </summary>
        [JsonProperty("sub_rate")]
        public double SubRate { get; set; }

        /// <summary>
        /// Gets or sets the unsub rate.
        /// </summary>
        [JsonProperty("unsub_rate")]
        public double UnsubRate { get; set; }
    }
}