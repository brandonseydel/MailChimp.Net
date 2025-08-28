// --------------------------------------------------------------------------------------------------------------------
// <copyright file="OpenLocation.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using Newtonsoft.Json;

namespace MailChimp.Net.Models;

/// <summary>
/// The open location.
/// </summary>
public class OpenLocation
{
    /// <summary>
    /// Gets or sets the country code.
    /// </summary>
    [JsonProperty("country_code")]
    public string CountryCode { get; set; }

    /// <summary>
    /// Gets or sets the opens.
    /// </summary>
    [JsonProperty("opens")]
    public int Opens { get; set; }

    /// <summary>
    /// Gets or sets the region.
    /// </summary>
    [JsonProperty("region")]
    public string Region { get; set; }
}