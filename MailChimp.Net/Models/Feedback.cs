// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Feedback.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;
using MailChimp.Net.Core;
using System;

// ReSharper disable UnusedAutoPropertyAccessor.Local
namespace MailChimp.Net.Models;

/// <summary>
/// The feedback.
/// </summary>
public class Feedback
{
    /// <summary>
    /// Gets or sets the block id.
    /// </summary>
    [MailChimpJsonProperty("block_id")]
    public int BlockId { get; set; }

    /// <summary>
    /// Gets the campaign id.
    /// </summary>
    [MailChimpJsonProperty("campaign_id")]
    public string CampaignId { get; set; }

    /// <summary>
    /// Gets the created at.
    /// </summary>
    [MailChimpJsonProperty("created_at")]
    public DateTime? CreatedAt { get; set; }

    /// <summary>
    /// Gets the created by.
    /// </summary>
    [MailChimpJsonProperty("created_by")]
    public string CreatedBy { get; set; }

    /// <summary>
    /// Gets the feedback id.
    /// </summary>
    [MailChimpJsonProperty("feedback_id")]
    public int? FeedbackId { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether is complete.
    /// </summary>
    [MailChimpJsonProperty("is_complete")]
    public bool IsComplete { get; set; }

    /// <summary>
    /// Gets the links.
    /// </summary>
    [MailChimpJsonProperty("_links")]
    public IEnumerable<Link> Links { get; set; }

    /// <summary>
    /// Gets or sets the message.
    /// </summary>
    [MailChimpJsonProperty("message")]
    public string Message { get; set; }

    /// <summary>
    /// Gets the parent id.
    /// </summary>
    [MailChimpJsonProperty("parent_id")]
    public int ParentId { get; set; }

    /// <summary>
    /// Gets the source.
    /// </summary>
    [MailChimpJsonProperty("source")]
		[MailChimpJsonConverter(MailChimpJsonConverterKind.StringEnumDescription)]
    public FeedbackSource Source { get; set; }

    /// <summary>
    /// Gets the updated at.
    /// </summary>
    [MailChimpJsonProperty("updated_at")]
    public DateTime? UpdatedAt { get; set; }
}