// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Archive.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    /// <summary>
    /// The archive.
    /// </summary>
    public class Archive
    {
        /// <summary>
        /// Gets or sets the archive content.
        /// </summary>
        [JsonProperty("archive_content")]
        public string ArchiveContent { get; set; }

        /// <summary>
        /// Gets or sets the archive type.
        /// </summary>
        [JsonProperty("arhive_type")]
        public string ArchiveType { get; set; }
    }
}