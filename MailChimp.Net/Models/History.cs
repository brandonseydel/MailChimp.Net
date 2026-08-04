// --------------------------------------------------------------------------------------------------------------------
// <copyright file="History.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using MailChimp.Net.Core;

namespace MailChimp.Net.Models;

/// <summary>
/// The history.
/// </summary>
public class History
{
    /// <summary>
    /// Gets or sets the existing.
    /// </summary>
    [MailChimpJsonProperty("existing")]
    public int Existing { get; set; }

    /// <summary>
    /// Gets or sets the imports.
    /// </summary>
    [MailChimpJsonProperty("imports")]
    public int Imports { get; set; }

    /// <summary>
    /// Gets or sets the links.
    /// </summary>
    [MailChimpJsonProperty("_links")]
    public Link[] Links { get; set; }

    /// <summary>
    /// Gets or sets the list id.
    /// </summary>
    [MailChimpJsonProperty("list_id")]
    public string ListId { get; set; }

    /// <summary>
    /// Gets or sets the month.
    /// </summary>
    [MailChimpJsonProperty("month")]
    public string Month { get; set; }

    /// <summary>
    /// Gets or sets the optins.
    /// </summary>
    [MailChimpJsonProperty("optins")]
    public int Optins { get; set; }
}