namespace MailChimp.Net.Core.Responses;

public class AddressResponse
{
    /// <summary>
    /// Gets or sets the address 1.
    /// </summary>
    [MailChimpJsonProperty("addr1")]
    public string Address1 { get; set; }

    /// <summary>
    /// Gets or sets the address 2.
    /// </summary>
    [MailChimpJsonProperty("addr2")]
    public string Address2 { get; set; }

    /// <summary>
    /// Gets or sets the city.
    /// </summary>
    [MailChimpJsonProperty("city")]
    public string City { get; set; }

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

    /// <summary>
    /// Gets or sets the country.
    /// </summary>
    [MailChimpJsonProperty("country")]
    public string Country { get; set; }
}