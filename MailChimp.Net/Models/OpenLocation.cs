// --------------------------------------------------------------------------------------------------------------------
// <copyright file="OpenLocation.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using MailChimp.Net.Core;

namespace MailChimp.Net.Models;

/// <summary>
/// The open location.
/// </summary>
public class OpenLocation
{
    /// <summary>
    /// Gets or sets the country code.
    /// </summary>
    [MailChimpJsonProperty("country_code")]
    public string CountryCode { get; set; }

    /// <summary>
    /// Gets or sets the opens.
    /// </summary>
    [MailChimpJsonProperty("opens")]
    public int Opens { get; set; }

    /// <summary>
    /// Gets or sets the region.
    /// </summary>
    [MailChimpJsonProperty("region")]
    public string Region { get; set; }
}