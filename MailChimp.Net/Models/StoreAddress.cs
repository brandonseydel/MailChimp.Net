using Newtonsoft.Json;

namespace MailChimp.Net.Models;

/// <summary>
/// Store address.
/// </summary>
public class StoreAddress : Address
{
    /// <summary>
    /// Gets or sets the latitude.
    /// </summary>
    [JsonProperty("latitude")]
    public decimal? Latitude { get; set; }

    /// <summary>
    /// Gets or sets the longitude.
    /// </summary>
    [JsonProperty("longitude")]
    public decimal? Longitude { get; set; }

}