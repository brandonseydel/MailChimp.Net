// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SentTo.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System;
using MailChimp.Net.Core;
namespace MailChimp.Net.Models;

/// <summary>
/// The sent to.
/// </summary>
public class SentTo
{
    /// <summary>
    /// Gets or sets the absplit group.
    /// </summary>
    [MailChimpJsonProperty("absplit_group")]
    public string AbsplitGroup { get; set; }

    /// <summary>
    /// Gets or sets the campaign id.
    /// </summary>
    [MailChimpJsonProperty("campaign_id")]
    public string CampaignId { get; set; }

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
    /// Gets or sets the gmt offset.
    /// </summary>
    [MailChimpJsonProperty("gmt_offset")]
    public int GmtOffset { get; set; }

    /// <summary>
    /// Gets or sets the last open.
    /// </summary>
    [MailChimpJsonProperty("last_open")]
    public DateTime? LastOpen { get; set; }

    /// <summary>
    /// Gets or sets the links.
    /// </summary>
    [MailChimpJsonProperty("_links")]
    public Link[] Links { get; set; }

    /// <summary>
    /// Gets or sets the list id.
    /// </summary>
    [MailChimpJsonProperty("list_id")]
    public string ListId { get; set; }

    /// <summary>
    /// Gets or sets the open count.
    /// </summary>
    [MailChimpJsonProperty("open_count")]
    public int OpenCount { get; set; }

    /// <summary>
    /// Gets or sets the status.
    /// </summary>
    [MailChimpJsonProperty("status")]
    public string Status { get; set; }
}