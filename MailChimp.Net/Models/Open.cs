// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Open.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

using MailChimp.Net.Core;
namespace MailChimp.Net.Models;

/// <summary>
/// The Open.
/// </summary>
public class Open
{
    /// <summary>
    /// Gets or sets the campaign id.
    /// </summary>
    [MailChimpJsonProperty("campaign_id")]
    public string CampaignId { get; set; }

    /// <summary>
    /// Gets or sets the list id.
    /// </summary>
    [MailChimpJsonProperty("list_id")]
    public string ListId { get; set; }

    /// <summary>
    /// Gets or sets the email id.
    /// </summary>
    [MailChimpJsonProperty("email_id")]
    public string EmailId { get; set; }

    /// <summary>
    /// Gets or sets the email address.
    /// </summary>
    [MailChimpJsonProperty("email_address")]
    public string EmailAddress { get; set; }

    /// <summary>
    /// Gets or sets the merge fields.
    /// </summary>
    [MailChimpJsonProperty("merge_fields")]
    public Dictionary<string, object> MergeFields { get; set; }

    /// <summary>
    /// Gets or sets the vip.
    /// </summary>
    [MailChimpJsonProperty("vip")]
    public bool VIP { get; set; }

    /// <summary>
    /// Gets or sets the clicks.
    /// </summary>
    [MailChimpJsonProperty("opens_count")]
    public int OpensCount { get; set; }

    /// <summary>
    /// Gets or sets the clicks.
    /// </summary>
    [MailChimpJsonProperty("opens")]
    public TimeStamp[] Opens  { get; set; }

    /// <summary>
    /// Gets or sets the links.
    /// </summary>
    [MailChimpJsonProperty("_links")]
    public IEnumerable<Link> Links { get; set; }

}