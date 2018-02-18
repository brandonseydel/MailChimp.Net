using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    /// <summary>
    /// Order address.
    /// </summary>
    public class OrderAddress : Address
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

        /// <summary>
        /// Gets or sets the longitude.
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// Gets or sets the longitude.
        /// </summary>
        [JsonProperty("company")]
        public string Company { get; set; }

    }
}