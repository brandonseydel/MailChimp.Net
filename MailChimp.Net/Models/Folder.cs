// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Folder.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;

using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    /// <summary>
    /// The folder.
    /// </summary>
    public class Folder
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Folder"/> class.
        /// </summary>
        public Folder()
        {
            Links = new HashSet<Link>();
        }

        /// <summary>
        /// Gets or sets the count.
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the links.
        /// </summary>
        [JsonProperty("_links")]
        public IEnumerable<Link> Links { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}