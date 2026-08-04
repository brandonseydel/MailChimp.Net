// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Folder.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;

using MailChimp.Net.Core;
namespace MailChimp.Net.Models;

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
    [MailChimpJsonProperty("count")]
    public int Count { get; set; }

    /// <summary>
    /// Gets or sets the id.
    /// </summary>
    [MailChimpJsonProperty("id")]
    public string Id { get; set; }

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
}