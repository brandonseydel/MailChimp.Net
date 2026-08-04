// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EepClick.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

using MailChimp.Net.Core;
namespace MailChimp.Net.Models;

/// <summary>
/// The eep click.
/// </summary>
public class EepClick
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
    /// Gets or sets the locations.
    /// </summary>
    [MailChimpJsonProperty("locations")]
    public IEnumerable<EepLocation> Locations { get; set; }
}