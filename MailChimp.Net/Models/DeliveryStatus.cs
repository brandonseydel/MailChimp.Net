// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DeliveryStatus.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using MailChimp.Net.Core;

namespace MailChimp.Net.Models;

/// <summary>
/// The delivery status.
/// </summary>
public class DeliveryStatus
{
    /// <summary>
    /// Gets or sets a value indicating whether enabled.
    /// </summary>
    [MailChimpJsonProperty("enabled")]
    public bool Enabled { get; set; }

    [MailChimpJsonProperty("can_cancel")]
    public bool CanCancel { get; set; }

    [MailChimpJsonProperty("status")]
    public string Status { get; set; }

    [MailChimpJsonProperty("emails_sent")]
    public int EmailsSent { get; set; }

    [MailChimpJsonProperty("emails_canceled")]
    public int EmailsCanceled { get; set; }
}