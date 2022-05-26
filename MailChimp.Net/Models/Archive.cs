// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Archive.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using Newtonsoft.Json;
using System.Diagnostics;

namespace MailChimp.Net.Models
{
    /// <summary>
    /// The archive.
    /// </summary>
    public class Archive : Base
    {
        /// <summary>
        /// Gets or sets the archive content. [Required]
        /// </summary>
        [JsonProperty("archive_content", Required = Required.Always)]
        public string ArchiveContent { get; set; }

        /// <summary>
        /// Gets or sets the archive type.
        /// </summary>
        [JsonProperty("archive_type")]
        public string ArchiveType { get; set; }

        internal override DisplayBuilder GetDebuggerDisplayBuilder(DisplayBuilder Builder) {
            return base.GetDebuggerDisplayBuilder(Builder)
                .Type.Add(ArchiveType)
                .Data.Add(ArchiveContent)
                ;
        }
    }
}