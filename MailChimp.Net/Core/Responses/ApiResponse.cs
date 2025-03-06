// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ApiResponse.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using MailChimp.Net.Models;

using Newtonsoft.Json;

namespace MailChimp.Net.Core
{
    /// <summary>
    /// The api response.
    /// </summary>
    public class ApiResponse
    {
        /// <summary>
        /// Gets or sets the account id.
        /// </summary>
        [JsonProperty("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// Gets or sets the account name.
        /// </summary>
        [JsonProperty("account_name")]
        public string AccountName { get; set; }

        /// <summary>
        /// Gets or sets the contact.
        /// </summary>
        [JsonProperty("contact")]
        public Contact Contact { get; set; }

        /// <summary>
        /// Gets or sets the last login.
        /// </summary>
        [JsonProperty("last_login")]
        public string LastLogin { get; set; }

        /// <summary>
        /// Gets or sets the links.
        /// </summary>
        [JsonProperty("_links")]
        public Link[] Links { get; set; }

        /// <summary>
        /// Gets or sets the total subscribers.
        /// </summary>
        [JsonProperty("total_subscribers")]
        public int TotalSubscribers { get; set; }
    }
}