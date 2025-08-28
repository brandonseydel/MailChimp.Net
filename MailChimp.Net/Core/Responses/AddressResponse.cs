using Newtonsoft.Json;

namespace MailChimp.Net.Core.Responses;

public class AddressResponse
{
    /// <summary>
    /// Gets or sets the address 1.
    /// </summary>
    [JsonProperty("addr1")]
    public string Address1 { get; set; }

    /// <summary>
    /// Gets or sets the address 2.
    /// </summary>
    [JsonProperty("addr2")]
    public string Address2 { get; set; }

    /// <summary>
    /// Gets or sets the city.
    /// </summary>
    [JsonProperty("city")]
    public string City { get; set; }

    /// <summary>
    /// Gets or sets the state.
    /// </summary>
    [JsonProperty("state")]
    public string State { get; set; }

    /// <summary>
    /// Gets or sets the zip.
    /// </summary>
    [JsonProperty("zip")]
    public string Zip { get; set; }

    /// <summary>
    /// Gets or sets the country.
    /// </summary>
    [JsonProperty("country")]
    public string Country { get; set; }
}