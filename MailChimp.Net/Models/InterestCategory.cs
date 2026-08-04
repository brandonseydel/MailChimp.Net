// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InterestCategory.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using MailChimp.Net.Core;

namespace MailChimp.Net.Models;

/// <summary>
/// The interest category.
/// </summary>
public class InterestCategory
{
    /// <summary>
    /// Gets or sets the display order.
    /// </summary>
    [MailChimpJsonProperty("display_order")]
    public int DisplayOrder { get; set; }

    /// <summary>
    /// Gets or sets the display type.
    /// </summary>
    [MailChimpJsonProperty("type")]
    public string DisplayType { get; set; }

    /// <summary>
    /// Gets the id.
    /// </summary>
    [MailChimpJsonProperty("id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets the list id.
    /// </summary>
    [MailChimpJsonProperty("list_id")]
    public string ListId { get; set; }

    /// <summary>
    /// Gets or sets the title.
    /// </summary>
    [MailChimpJsonProperty("title")]
    public string Title { get; set; }
}