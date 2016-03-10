// --------------------------------------------------------------------------------------------------------------------
// <copyright file="History.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    /// <summary>
    /// The history.
    /// </summary>
    public class History
    {
        /// <summary>
        /// Gets or sets the existing.
        /// </summary>
        [JsonProperty("existing")]
        public int Existing { get; set; }

        /// <summary>
        /// Gets or sets the imports.
        /// </summary>
        [JsonProperty("imports")]
        public int Imports { get; set; }

        /// <summary>
        /// Gets or sets the links.
        /// </summary>
        [JsonProperty("_links")]
        public Link[] Links { get; set; }

        /// <summary>
        /// Gets or sets the list id.
        /// </summary>
        [JsonProperty("list_id")]
        public string ListId { get; set; }

        /// <summary>
        /// Gets or sets the month.
        /// </summary>
        [JsonProperty("month")]
        public string Month { get; set; }

        /// <summary>
        /// Gets or sets the optins.
        /// </summary>
        [JsonProperty("optins")]
        public int Optins { get; set; }
    }
}