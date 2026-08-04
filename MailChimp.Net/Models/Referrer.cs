// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Referrer.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System;
using MailChimp.Net.Core;
namespace MailChimp.Net.Models;

/// <summary>
/// The referrer.
/// </summary>
public class Referrer
{
    /// <summary>
    /// Gets or sets the clicks.
    /// </summary>
    [MailChimpJsonProperty("clicks")]
    public int Clicks { get; set; }

    /// <summary>
    /// Gets or sets the first click.
    /// </summary>
    [MailChimpJsonProperty("first_click")]
    public DateTime? FirstClick { get; set; }

    /// <summary>
    /// Gets or sets the last click.
    /// </summary>
    [MailChimpJsonProperty("last_click")]
    public DateTime? LastClick { get; set; }

    /// <summary>
    /// Gets or sets the name.
    /// </summary>
    [MailChimpJsonProperty("referrer")]
    public string Name { get; set; }
}