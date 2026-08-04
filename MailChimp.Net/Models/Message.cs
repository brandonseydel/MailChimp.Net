// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Message.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using MailChimp.Net.Core;

namespace MailChimp.Net.Models;

/// <summary>
/// The message.
/// </summary>
public class Message
{
    /// <summary>
    /// Gets or sets the body.
    /// </summary>
    [MailChimpJsonProperty("message")]
    public string Body { get; set; }

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
    /// Gets or sets a value indicating whether read.
    /// </summary>
    [MailChimpJsonProperty("read")]
    public bool Read { get; set; }

    /// <summary>
    /// Gets or sets the subject.
    /// </summary>
    [MailChimpJsonProperty("subject")]
    public string Subject { get; set; }

    /// <summary>
    /// Gets or sets the timestamp.
    /// </summary>
    [MailChimpJsonProperty("timestamp")]
    public string Timestamp { get; set; }
}