// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Store.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------



using System;
using System.Collections.Generic;

using MailChimp.Net.Core;

namespace MailChimp.Net.Models;

/// <summary>
/// The store.
/// </summary>
public class Store
{
    public Store()
    {
        Links = new HashSet<Link>();
    }

    /// <summary>
    /// Gets or sets the address.
    /// </summary>
    [MailChimpJsonProperty("address")]
    public StoreAddress Address { get; set; }

    /// <summary>
    /// Gets or sets the created at.
    /// </summary>
    [MailChimpJsonProperty("created_at")]
    public DateTime? CreatedAt { get; set; }

    /// <summary>
    /// Gets or sets the currency code.
    /// </summary>
    [MailChimpJsonProperty("currency_code")]
    [MailChimpJsonConverter(MailChimpJsonConverterKind.StringEnumDescription)]
    public CurrencyCode CurrencyCode { get; set; }

    /// <summary>
    /// Gets or sets the platform.
    /// </summary>
    [MailChimpJsonProperty("platform")]
    public string Platform { get; set; }


    /// <summary>
    /// Gets or sets the syncing flag.
    /// </summary>
    [MailChimpJsonProperty("is_syncing")]
    public bool IsSyncing { get; set; }

    /// <summary>
    /// Gets or sets the domain.
    /// </summary>
    [MailChimpJsonProperty("domain")]
    public string Domain { get; set; }

    /// <summary>
    /// Gets or sets the email address.
    /// </summary>
    [MailChimpJsonProperty("email_address")]
    public string EmailAddress { get; set; }

    /// <summary>
    /// The unique identifier for the store.
    /// </summary>
    [MailChimpJsonProperty("id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or sets the links.
    /// </summary>
    [MailChimpJsonProperty("_links")]
    public IEnumerable<Link> Links { get; set; }

    /// <summary>
    /// The unique identifier for the <a href="http://developer.mailchimp.com/documentation/mailchimp/reference/lists/">MailChimp List</a> associated with the store. The list_id for a specific store cannot change.
    /// </summary>
    [MailChimpJsonProperty("list_id")]
    public string ListId { get; set; }

    /// <summary>
    /// Gets or sets the money format.
    /// For example: $, £, etc.
    /// </summary>
    [MailChimpJsonProperty("money_format")]
    public string MoneyFormat { get; set; }

    /// <summary>
    /// Gets or sets the name.
    /// </summary>
    [MailChimpJsonProperty("name")]
    public string Name { get; set; }

    /// <summary>
    /// The store phone number.
    /// </summary>
    [MailChimpJsonProperty("phone")]
    public string Phone { get; set; }

    /// <summary>
    /// Gets or sets the primary locale.
    /// For example: en, de, etc.
    /// </summary>
    [MailChimpJsonProperty("primary_locale")]
    public string PrimaryLocale { get; set; }

    /// <summary>
    /// The timezone for the store.
    /// </summary>
    [MailChimpJsonProperty("timezone")]
    public string Timezone { get; set; }

    /// <summary>
    /// Gets or sets the updated at.
    /// </summary>
    [MailChimpJsonProperty("updated_at")]
    public DateTime? UpdatedAt { get; set; }
}