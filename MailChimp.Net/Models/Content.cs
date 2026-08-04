// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Content.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;
using MailChimp.Net.Core;
namespace MailChimp.Net.Models;

/// <summary>
/// The content.
/// </summary>
public class Content
{
    /// <summary>
    /// Gets or sets the html.
    /// </summary>
    [MailChimpJsonProperty("html")]
    public string Html { get; set; }

    /// <summary>
    /// Gets or sets the links.
    /// </summary>
    [MailChimpJsonProperty("_links")]
    public IEnumerable<Link> Links { get; set; }

    /// <summary>
    /// </summary>
    [MailChimpJsonProperty("variate_contents")]
    public IEnumerable<VariateContents> VariateContents { get; set; }

    /// <summary>
    /// Gets or sets the plain text.
    /// </summary>
    [MailChimpJsonProperty("plain_text")]
    public string PlainText { get; set; }

    /// <summary>
    /// The Archive HTML for the campaign.
    /// </summary>
    [MailChimpJsonProperty("archive_html")]
    public string ArchiveHtml { get; set; }
}