using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    /// <summary>
    /// Order address.
    /// </summary>
    public class OrderAddress : Address
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

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

        /// <summary>
        /// Gets or sets the phone number.
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// Gets or sets the company name.
        /// </summary>
        [JsonProperty("company")]
        public string Company { get; set; }

    }
}