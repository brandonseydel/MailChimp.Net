// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Store.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------



using System;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    /// <summary>
    /// The store.
    /// </summary>
    public class Store
    {
        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        [JsonProperty("address")]
        public Address Address { get; set; }

        /// <summary>
        /// Gets or sets the created at.
        /// </summary>
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets the currency code.
        /// </summary>
        [JsonProperty("currency_code")]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Gets or sets the domain.
        /// </summary>
        [JsonProperty("domain")]
        public string Domain { get; set; }

        /// <summary>
        /// Gets or sets the email address.
        /// </summary>
        [JsonProperty("email_address")]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the links.
        /// </summary>
        [JsonProperty("_links")]
        public IEnumerable<Link> Links { get; set; }

        /// <summary>
        /// Gets or sets the list id.
        /// </summary>
        [JsonProperty("list_id")]
        public string ListId { get; set; }

        /// <summary>
        /// Gets or sets the money format.
        /// </summary>
        [JsonProperty("money_format")]
        public string MoneyFormat { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the phone.
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// Gets or sets the primary locale.
        /// </summary>
        [JsonProperty("primary_locale")]
        public string PrimaryLocale { get; set; }

        /// <summary>
        /// Gets or sets the timezone.
        /// </summary>
        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        /// <summary>
        /// Gets or sets the updated at.
        /// </summary>
        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }
    }
}