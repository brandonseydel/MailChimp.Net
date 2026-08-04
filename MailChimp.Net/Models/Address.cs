// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Address.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


using MailChimp.Net.Core;

namespace MailChimp.Net.Models;

/// <summary>
/// The address.
/// </summary>
public class Address
{
    /// <summary>
    /// Gets or sets the address 1.
    /// </summary>
    [MailChimpJsonProperty("address1")]
    public string Address1 { get; set; }

    /// <summary>
    /// Gets or sets the address 2.
    /// </summary>
    [MailChimpJsonProperty("address2")]
    public string Address2 { get; set; }

    /// <summary>
    /// Gets or sets the city.
    /// </summary>
    [MailChimpJsonProperty("city")]
    public string City { get; set; }

    /// <summary>
    /// Gets or sets the country.
    /// </summary>
    [MailChimpJsonProperty("country")]
    public string Country { get; set; }

    /// <summary>
    /// Gets or sets the country code.
    /// </summary>
    [MailChimpJsonProperty("country_code")]
    public string CountryCode { get; set; }

    /// <summary>
    /// Gets or sets the postal code.
    /// </summary>
    [MailChimpJsonProperty("postal_code")]
    public string PostalCode { get; set; }

    /// <summary>
    /// Gets or sets the province.
    /// </summary>
    [MailChimpJsonProperty("province")]
    public string Province { get; set; }

    /// <summary>
    /// Gets or sets the province code.
    /// </summary>
    [MailChimpJsonProperty("province_code")]
    public string ProvinceCode { get; set; }
}