// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CheckList.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using MailChimp.Net.Core;

namespace MailChimp.Net.Models;

/// <summary>
/// The check list.
/// </summary>
public class CheckList
{
    /// <summary>
    /// Gets or sets the details.
    /// </summary>
    [MailChimpJsonProperty("details")]
    public string Details { get; set; }

    /// <summary>
    /// Gets or sets the heading.
    /// </summary>
    [MailChimpJsonProperty("heading")]
    public string Heading { get; set; }

    /// <summary>
    /// Gets or sets the type.
    /// </summary>
    [MailChimpJsonProperty("type")]
    public Core.Result Type { get; set; }
}