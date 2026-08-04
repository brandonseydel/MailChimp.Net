// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Hours.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using MailChimp.Net.Core;

namespace MailChimp.Net.Models;

/// <summary>
/// The hours.
/// </summary>
public class Hours
{
    /// <summary>
    /// Gets or sets the send at.
    /// </summary>
    [MailChimpJsonProperty("send_at")]
    public string SendAt { get; set; }
}