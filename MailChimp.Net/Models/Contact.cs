// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Contact.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using MailChimp.Net.Core;

namespace MailChimp.Net.Models;

/// <summary>
/// The contact.
/// </summary>
public class Contact
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
    /// Gets or sets the company.
    /// </summary>
    [MailChimpJsonProperty("company")]
    public string Company { get; set; }

    /// <summary>
    /// Gets or sets the country.
    /// </summary>
    [MailChimpJsonProperty("country")]
    public string Country { get; set; }

    /// <summary>
    /// Gets or sets the phone.
    /// </summary>
    [MailChimpJsonProperty("phone")]
    public string Phone { get; set; }

    /// <summary>
    /// Gets or sets the state.
    /// </summary>
    [MailChimpJsonProperty("state")]
    public string State { get; set; }

    /// <summary>
    /// Gets or sets the zip.
    /// </summary>
    [MailChimpJsonProperty("zip")]
    public string Zip { get; set; }
}