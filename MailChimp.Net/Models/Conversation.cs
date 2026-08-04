// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Conversation.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using MailChimp.Net.Core;

namespace MailChimp.Net.Models;

/// <summary>
/// The conversation.
/// </summary>
public class Conversation
{
    /// <summary>
    /// Gets or sets the campaign id.
    /// </summary>
    [MailChimpJsonProperty("campaign_id")]
    public string CampaignId { get; set; }

    /// <summary>
    /// Gets or sets the from email.
    /// </summary>
    [MailChimpJsonProperty("from_email")]
    public string FromEmail { get; set; }

    /// <summary>
    /// Gets or sets the from label.
    /// </summary>
    [MailChimpJsonProperty("from_label")]
    public string FromLabel { get; set; }

    /// <summary>
    /// Gets or sets the id.
    /// </summary>
    [MailChimpJsonProperty("id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or sets the last message.
    /// </summary>
    [MailChimpJsonProperty("last_message")]
    public Message LastMessage { get; set; }

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
    /// Gets or sets the message count.
    /// </summary>
    [MailChimpJsonProperty("message_count")]
    public int MessageCount { get; set; }

    /// <summary>
    /// Gets or sets the subject.
    /// </summary>
    [MailChimpJsonProperty("subject")]
    public string Subject { get; set; }

    /// <summary>
    /// Gets or sets the unread messages.
    /// </summary>
    [MailChimpJsonProperty("unread_messages")]
    public int UnreadMessages { get; set; }
}