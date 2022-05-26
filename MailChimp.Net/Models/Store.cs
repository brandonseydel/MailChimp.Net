// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Store.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------



using System;
using System.Collections.Generic;

using Newtonsoft.Json;
using MailChimp.Net.Core;
using System.Diagnostics;

namespace MailChimp.Net.Models
{
    /// <summary>
    /// The store.
    /// </summary>
    public class Store : Base, IId<string>
    {
        public Store()
        {
            Links = new HashSet<Link>();
        }

        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        [JsonProperty("address")]
        public StoreAddress Address { get; set; }

        /// <summary>
        /// Gets or sets the created at.
        /// </summary>
        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets the currency code.
        /// </summary>
        [JsonProperty("currency_code")]
        [JsonConverter(typeof(StringEnumDescriptionConverter))]
        public CurrencyCode CurrencyCode { get; set; }

        /// <summary>
        /// Gets or sets the platform.
        /// </summary>
        [JsonProperty("platform")]
        public string Platform { get; set; }


        /// <summary>
        /// Gets or sets the syncing flag.
        /// </summary>
        [JsonProperty("is_syncing")]
        public bool IsSyncing { get; set; }

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
        /// The unique identifier for the store.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the links.
        /// </summary>
        [JsonProperty("_links")]
        public IEnumerable<Link> Links { get; set; }

        /// <summary>
        /// The unique identifier for the <a href="http://developer.mailchimp.com/documentation/mailchimp/reference/lists/">MailChimp List</a> associated with the store. The list_id for a specific store cannot change.
        /// </summary>
        [JsonProperty("list_id")]
        public string ListId { get; set; }

        /// <summary>
        /// Gets or sets the money format.
        /// For example: $, £, etc.
        /// </summary>
        [JsonProperty("money_format")]
        public string MoneyFormat { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The store phone number.
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// Gets or sets the primary locale.
        /// For example: en, de, etc.
        /// </summary>
        [JsonProperty("primary_locale")]
        public string PrimaryLocale { get; set; }

        /// <summary>
        /// The timezone for the store.
        /// </summary>
        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        /// <summary>
        /// Gets or sets the updated at.
        /// </summary>
        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt { get; set; }

        internal override DisplayBuilder GetDebuggerDisplayBuilder(DisplayBuilder Builder) {
            return base.GetDebuggerDisplayBuilder(Builder)
                .Id.Add(Id)
                .Type.Add(Platform)
                .Data.Add(Name)
                ;
        }
    }
}