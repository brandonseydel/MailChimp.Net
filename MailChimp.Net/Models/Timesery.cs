// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Timesery.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using MailChimp.Net.Core;

namespace MailChimp.Net.Models;

/// <summary>
/// The timesery.
/// </summary>
public class Timesery
{
    /// <summary>
    /// Gets or sets the emails sent.
    /// </summary>
    [MailChimpJsonProperty("emails_sent")]
    public int EmailsSent { get; set; }

    /// <summary>
    /// Gets or sets the recipients clicks.
    /// </summary>
    [MailChimpJsonProperty("recipients_clicks")]
    public int RecipientsClicks { get; set; }

    /// <summary>
    /// Gets or sets the timestamp.
    /// </summary>
    [MailChimpJsonProperty("timestamp")]
    public string Timestamp { get; set; }

    /// <summary>
    /// Gets or sets the unique opens.
    /// </summary>
    [MailChimpJsonProperty("unique_opens")]
    public int UniqueOpens { get; set; }
}