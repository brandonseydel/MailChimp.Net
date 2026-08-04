// --------------------------------------------------------------------------------------------------------------------
// <copyright file="App.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using MailChimp.Net.Core;

namespace MailChimp.Net.Models;

/// <summary>
/// The app.
/// </summary>
public class App
{
    /// <summary>
    /// Gets or sets the description.
    /// </summary>
    [MailChimpJsonProperty("description")]
    public string Description { get; set; }

    /// <summary>
    /// Gets or sets the id.
    /// </summary>
    [MailChimpJsonProperty("id")]
    public object Id { get; set; }

    /// <summary>
    /// Gets or sets the links.
    /// </summary>
    [MailChimpJsonProperty("_links")]
    public Link[] Links { get; set; }

    /// <summary>
    /// Gets or sets the name.
    /// </summary>
    [MailChimpJsonProperty("name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets the users.
    /// </summary>
    [MailChimpJsonProperty("users")]
    public string[] Users { get; set; }
}