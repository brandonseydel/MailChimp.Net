// --------------------------------------------------------------------------------------------------------------------
// <copyright file="List.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

using MailChimp.Net.Core;

namespace MailChimp.Net.Models;

/// <summary>
/// The list.
/// </summary>
public class List
{
    /// <summary>
    /// Initializes a new instance of the <see cref="List"/> class.
    /// </summary>
    public List()
    {
        Links = new HashSet<Link>();
        Visibility = Visibility.Private;
    }

    /// <summary>
    /// Gets or sets the beamer address.
    /// </summary>
    [MailChimpJsonProperty("beamer_address")]
    public string BeamerAddress { get; set; }

    /// <summary>
    /// Gets or sets the campaign defaults.
    /// </summary>
    [MailChimpJsonProperty("campaign_defaults")]
    public CampaignDefaults CampaignDefaults { get; set; }

    /// <summary>
    /// Gets or sets the contact.
    /// </summary>
    [MailChimpJsonProperty("contact")]
    public Contact Contact { get; set; }

    /// <summary>
    /// Gets or sets the date created.
    /// </summary>
    [MailChimpJsonProperty("date_created")]
    public DateTime DateCreated { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether email type option.
    /// </summary>
    [MailChimpJsonProperty("email_type_option")]
    public bool EmailTypeOption { get; set; }

    /// <summary>
    /// Gets or sets the id.
    /// </summary>
    [MailChimpJsonProperty("id")]
    public string Id { get; set; } 

    /// <summary>
    /// Gets or sets the web id.
    /// </summary>
    [MailChimpJsonProperty("web_id")]
    public int WebId { get; set; }

    /// <summary>
    /// Gets or sets the links.
    /// </summary>
    [MailChimpJsonProperty("_links")]
    public IEnumerable<Link> Links { get; set; }

    /// <summary>
    /// Gets or sets the list rating.
    /// </summary>
    [MailChimpJsonProperty("list_rating")]
    public int ListRating { get; set; }

    /// <summary>
    /// Gets or sets the modules.
    /// </summary>
    [MailChimpJsonProperty("modules")]
    public object[] Modules { get; set; }

    /// <summary>
    /// Gets or sets the name.
    /// </summary>
    [MailChimpJsonProperty("name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets the notify on subscribe.
    /// </summary>
    [MailChimpJsonProperty("notify_on_subscribe")]
    public string NotifyOnSubscribe { get; set; }

    /// <summary>
    /// Gets or sets the notify on unsubscribe.
    /// </summary>
    [MailChimpJsonProperty("notify_on_unsubscribe")]
    public string NotifyOnUnsubscribe { get; set; }

    /// <summary>
    /// Gets or sets the permission reminder.
    /// </summary>
    [MailChimpJsonProperty("permission_reminder")]
    public string PermissionReminder { get; set; }

    /// <summary>
    /// Gets or sets the stats.
    /// </summary>
    [MailChimpJsonProperty("stats")]
    public Stats Stats { get; set; }

    /// <summary>
    /// Gets or sets the subscribe url long.
    /// </summary>
    [MailChimpJsonProperty("subscribe_url_long")]
    public string SubscribeUrlLong { get; set; }

    /// <summary>
    /// Gets or sets the subscribe url short.
    /// </summary>
    [MailChimpJsonProperty("subscribe_url_short")]
    public string SubscribeUrlShort { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether use archive bar.
    /// </summary>
    [MailChimpJsonProperty("use_archive_bar")]
    public bool UseArchiveBar { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether or not the list 
    /// has marketing permissions (eg. GDPR) enabled.
    /// </summary>
    [MailChimpJsonProperty("marketing_permissions")]
    public bool MarketingPermissions { get; set; }

    /// <summary>
    /// Whether or not to require the subscriber to confirm subscription via email.
    /// </summary>
    [MailChimpJsonProperty("double_optin")]
    public bool DoubleOptin { get; set; }

    /// <summary>
    /// Whether or not this list has a welcome automation connected. Welcome Automations: welcomeSeries, singleWelcome, emailFollowup.
    /// </summary>
    [MailChimpJsonProperty("has_welcome")]
    public bool HasWelcome { get; set; }

    /// <summary>
    /// Gets or sets the visibility.
    /// </summary>
    [MailChimpJsonProperty("visibility")]
    [MailChimpJsonConverter(MailChimpJsonConverterKind.StringEnumDescription)]
    public Visibility Visibility { get; set; }
}