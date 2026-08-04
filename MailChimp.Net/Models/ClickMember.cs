// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ClickMember.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;

using MailChimp.Net.Core;
namespace MailChimp.Net.Models;

/// <summary>
/// The click member.
/// </summary>
public class ClickMember
{
    /// <summary>
    /// Gets or sets the campaign id.
    /// </summary>
    [MailChimpJsonProperty("campaign_id")]
    public string CampaignId { get; set; }

    /// <summary>
    /// Gets or sets the clicks.
    /// </summary>
    [MailChimpJsonProperty("clicks")]
    public int Clicks { get; set; }

    /// <summary>
    /// Gets or sets the email address.
    /// </summary>
    [MailChimpJsonProperty("email_address")]
    public string EmailAddress { get; set; }

    /// <summary>
    /// Gets or sets the email id.
    /// </summary>
    [MailChimpJsonProperty("email_id")]
    public string EmailId { get; set; }

    /// <summary>
    /// Gets or sets the links.
    /// </summary>
    [MailChimpJsonProperty("_links")]
    public IEnumerable<Link> Links { get; set; }

    /// <summary>
    /// Gets or sets the list id.
    /// </summary>
    [MailChimpJsonProperty("list_id")]
    public string ListId { get; set; }

    /// <summary>
    /// Gets or sets the url id.
    /// </summary>
    [MailChimpJsonProperty("url_id")]
    public string UrlId { get; set; }
}