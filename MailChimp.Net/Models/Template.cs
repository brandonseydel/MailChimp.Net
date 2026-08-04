// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Template.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;

using MailChimp.Net.Core;

namespace MailChimp.Net.Models;

/// <summary>
/// The template.
/// </summary>
public class Template
{
    /// <summary>
    /// Gets or sets a value indicating whether active.
    /// </summary>
    [MailChimpJsonProperty("active")]
    public bool Active { get; set; }

    /// <summary>
    /// Gets or sets the category.
    /// </summary>
    [MailChimpJsonProperty("category")]
    public string Category { get; set; }

    /// <summary>
    /// Gets or sets the created by.
    /// </summary>
    [MailChimpJsonProperty("created_by")]
    public string CreatedBy { get; set; }

    /// <summary>
    /// Gets or sets the date created.
    /// </summary>
    [MailChimpJsonProperty("date_created")]
    public string DateCreated { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether drag and drop.
    /// </summary>
    [MailChimpJsonProperty("drag_and_drop")]
    public bool DragAndDrop { get; set; }

    /// <summary>
    /// Gets or sets the folder id.
    /// </summary>
    [MailChimpJsonProperty("folder_id")]
    public string FolderId { get; set; }

    /// <summary>
    /// Gets or sets the id.
    /// </summary>
    [MailChimpJsonProperty("id")]
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the links.
    /// </summary>
    [MailChimpJsonProperty("_links")]
    public IEnumerable<Link> Links { get; set; }

    /// <summary>
    /// Gets or sets the name.
    /// </summary>
    [MailChimpJsonProperty("name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether responsive.
    /// </summary>
    [MailChimpJsonProperty("responsive")]
    public bool Responsive { get; set; }

    /// <summary>
    /// Gets or sets the share url.
    /// </summary>
    [MailChimpJsonProperty("share_url")]
    public string ShareUrl { get; set; }

    /// <summary>
    /// Gets or sets the thumbnail.
    /// </summary>
    [MailChimpJsonProperty("thumbnail")]
    public string Thumbnail { get; set; }

    /// <summary>
    /// Gets or sets the type.
    /// </summary>
    [MailChimpJsonProperty("type")]
    [MailChimpJsonConverter(MailChimpJsonConverterKind.StringEnumDescription)]
    public TemplateType Type { get; set; }
}