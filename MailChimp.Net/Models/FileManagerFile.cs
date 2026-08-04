// --------------------------------------------------------------------------------------------------------------------
// <copyright file="File.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// <summary>
//   The file manager file.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using MailChimp.Net.Core;

namespace MailChimp.Net.Models;

/// <summary>
/// The file manager file.
/// </summary>
public class FileManagerFile
{

    [MailChimpJsonProperty("id")]
    public int Id { get; set; }

    [MailChimpJsonProperty("folder_id")]
    public int FolderId { get; set; }

    [MailChimpJsonProperty("type")]
    [MailChimpJsonConverter(MailChimpJsonConverterKind.StringEnumDescription)]
    public FileType Type { get; set; }

    [MailChimpJsonProperty("name")]
    public string Name { get; set; }

    [MailChimpJsonProperty("full_size_url")]
    public string FullSizeUrl { get; set; }

    [MailChimpJsonProperty("thumbnail_url")]
    public string ThumbnailUrl { get; set; }

    [MailChimpJsonProperty("size")]
    public int Size { get; set; }

    [MailChimpJsonProperty("created_at")]
    public DateTime? CreatedAt { get; set; }

    [MailChimpJsonProperty("created_by")]
    public string CreatedBy { get; set; }

    [MailChimpJsonProperty("width")]
    public int Width { get; set; }

    [MailChimpJsonProperty("height")]
    public int Height { get; set; }

    [MailChimpJsonProperty("_links")]
    public IList<Link> Links { get; set; }
}
