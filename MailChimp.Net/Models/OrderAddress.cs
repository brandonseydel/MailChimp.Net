using MailChimp.Net.Core;

namespace MailChimp.Net.Models;

/// <summary>
/// Order address.
/// </summary>
public class OrderAddress : Address
{
    /// <summary>
    /// Gets or sets the name.
    /// </summary>
    [MailChimpJsonProperty("name")]
    public string Name { get; set; }

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

    /// <summary>
    /// Gets or sets the phone number.
    /// </summary>
    [MailChimpJsonProperty("phone")]
    public string Phone { get; set; }

    /// <summary>
    /// Gets or sets the company name.
    /// </summary>
    [MailChimpJsonProperty("company")]
    public string Company { get; set; }

}