// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IndustryStats.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using MailChimp.Net.Core;

namespace MailChimp.Net.Models;

/// <summary>
/// The industry stats.
/// </summary>
public class IndustryStats
{
    /// <summary>
    /// Gets or sets the abuse rate.
    /// </summary>
    [MailChimpJsonProperty("abuse_rate")]
    public double AbuseRate { get; set; }

    /// <summary>
    /// Gets or sets the bounce rate.
    /// </summary>
    [MailChimpJsonProperty("bounce_rate")]
    public double BounceRate { get; set; }

    /// <summary>
    /// Gets or sets the click rate.
    /// </summary>
    [MailChimpJsonProperty("click_rate")]
    public double ClickRate { get; set; }

    /// <summary>
    /// Gets or sets the open rate.
    /// </summary>
    [MailChimpJsonProperty("open_rate")]
    public double OpenRate { get; set; }

    /// <summary>
    /// Gets or sets the result.
    /// </summary>
    [MailChimpJsonProperty("type")]
    public string Result { get; set; }

    /// <summary>
    /// Gets or sets the unopen rate.
    /// </summary>
    [MailChimpJsonProperty("unopen_rate")]
    public double UnopenRate { get; set; }

    /// <summary>
    /// Gets or sets the unsub rate.
    /// </summary>
    [MailChimpJsonProperty("unsub_rate")]
    public double UnsubRate { get; set; }
}