// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Address.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------



using System;

using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    /// <summary>
    /// The address.
    /// </summary>
    public class Address
    {
        /// <summary>
        /// Gets or sets the address 1.
        /// </summary>
        [JsonProperty("address1")]
        public string Address1 { get; set; }

        /// <summary>
        /// Gets or sets the address 2.
        /// </summary>
        [JsonProperty("address2")]
        public string Address2 { get; set; }

        /// <summary>
        /// Gets or sets the city.
        /// </summary>
        [JsonProperty("city")]
        public string City { get; set; }

        /// <summary>
        /// Gets or sets the country.
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; }

        /// <summary>
        /// Gets or sets the country code.
        /// </summary>
        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

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
        /// Gets or sets the postal code.
        /// </summary>
        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        /// <summary>
        /// Gets or sets the province.
        /// </summary>
        [JsonProperty("province")]
        public string Province { get; set; }

        /// <summary>
        /// Gets or sets the province code.
        /// </summary>
        [JsonProperty("province_code")]
        public string ProvinceCode { get; set; }
    }
}