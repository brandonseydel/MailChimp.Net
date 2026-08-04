// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InterestCategoryResponse.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;

using MailChimp.Net.Models;

namespace MailChimp.Net.Core;

/// <summary>
/// The interest category response.
/// </summary>
public class InterestCategoryResponse
{
    /// <summary>
    /// Initializes a new instance of the <see cref="InterestCategoryResponse"/> class.
    /// </summary>
    public InterestCategoryResponse()
    {
        Links = new HashSet<Link>();
        Categories = new HashSet<InterestCategory>();
    }

    /// <summary>
    /// Gets or sets the categories.
    /// </summary>
    [MailChimpJsonProperty("categories")]
    public IEnumerable<InterestCategory> Categories { get; set; }

    /// <summary>
    /// Gets or sets the links.
    /// </summary>
    [MailChimpJsonProperty("_links")]
    public IEnumerable<Link> Links { get; set; }

    /// <summary>
    /// Gets or sets the list id.
    /// </summary>
    [MailChimpJsonProperty("list_id")]
    public string ListId { get; set; }

    /// <summary>
    /// Gets or sets the total items.
    /// </summary>
    [MailChimpJsonProperty("total_items")]
    public int TotalItems { get; set; }
}