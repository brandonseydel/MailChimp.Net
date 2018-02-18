using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    /// <summary>
    /// Order address.
    /// </summary>
    public class StoreAddress : Address
    {
        /// <summary>
        /// Gets or sets the latitude.
        /// </summary>
        [JsonProperty("latitude")]
        public int Latitude { get; set; }

        /// <summary>
        /// Gets or sets the longitude.
        /// </summary>
        [JsonProperty("longitude")]
        public int Longitude { get; set; }

    }
}