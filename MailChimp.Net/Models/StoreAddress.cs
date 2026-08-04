using MailChimp.Net.Core;

namespace MailChimp.Net.Models;

/// <summary>
/// Store address.
/// </summary>
public class StoreAddress : Address
{
    /// <summary>
    /// Gets or sets the latitude.
    /// </summary>
    [MailChimpJsonProperty("latitude")]
    public decimal? Latitude { get; set; }

    /// <summary>
    /// Gets or sets the longitude.
    /// </summary>
    [MailChimpJsonProperty("longitude")]
    public decimal? Longitude { get; set; }

}