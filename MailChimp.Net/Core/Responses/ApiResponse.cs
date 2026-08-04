// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ApiResponse.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using MailChimp.Net.Models;

namespace MailChimp.Net.Core;

/// <summary>
/// The api response.
/// </summary>
public class ApiResponse
{
    /// <summary>
    /// Gets or sets the account id.
    /// </summary>
    [MailChimpJsonProperty("account_id")]
    public string AccountId { get; set; }

    /// <summary>
    /// Gets or sets the account name.
    /// </summary>
    [MailChimpJsonProperty("account_name")]
    public string AccountName { get; set; }

    /// <summary>
    /// Gets or sets the contact.
    /// </summary>
    [MailChimpJsonProperty("contact")]
    public Contact Contact { get; set; }

    /// <summary>
    /// Gets or sets the last login.
    /// </summary>
    [MailChimpJsonProperty("last_login")]
    public string LastLogin { get; set; }

    /// <summary>
    /// Gets or sets the links.
    /// </summary>
    [MailChimpJsonProperty("_links")]
    public Link[] Links { get; set; }

    /// <summary>
    /// Gets or sets the total subscribers.
    /// </summary>
    [MailChimpJsonProperty("total_subscribers")]
    public int TotalSubscribers { get; set; }
}