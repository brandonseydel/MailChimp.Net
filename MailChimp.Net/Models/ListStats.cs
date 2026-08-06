// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ListStats.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using MailChimp.Net.Core;

namespace MailChimp.Net.Models;

/// <summary>
/// The list stats.
/// </summary>
public class ListStats
{
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
    /// Gets or sets the sub rate.
    /// </summary>
    [MailChimpJsonProperty("sub_rate")]
    public double SubRate { get; set; }

    /// <summary>
    /// Gets or sets the unsub rate.
    /// </summary>
    [MailChimpJsonProperty("unsub_rate")]
    public double UnsubRate { get; set; }

    /// <summary>
    /// Gets or sets the proxy excluded open rate.
    /// </summary>
    [MailChimpJsonProperty("proxy_excluded_open_rate")]
    public double ProxyExcludedOpenRate { get; set; }
}