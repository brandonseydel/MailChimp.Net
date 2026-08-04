// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Archive.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using MailChimp.Net.Core;

namespace MailChimp.Net.Models;

/// <summary>
/// The archive.
/// </summary>
public class Archive
{
    /// <summary>
    /// Gets or sets the archive content. [Required]
    /// </summary>
    [MailChimpJsonProperty("archive_content")]
    public string ArchiveContent { get; set; }

    /// <summary>
    /// Gets or sets the archive type.
    /// </summary>
    [MailChimpJsonProperty("archive_type")]
    public string ArchiveType { get; set; }
}