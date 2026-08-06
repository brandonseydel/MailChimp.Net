// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Opens.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System;
using MailChimp.Net.Core;
namespace MailChimp.Net.Models;

/// <summary>
/// The opens.
/// </summary>
public class Opens
{
    /// <summary>
    /// Gets or sets the last open.
    /// </summary>
    [MailChimpJsonProperty("last_open")]
    public DateTime? LastOpen { get; set; }

    /// <summary>
    /// Gets or sets the open rate.
    /// </summary>
    [MailChimpJsonProperty("open_rate")]
    public double OpenRate { get; set; }

    /// <summary>
    /// Gets or sets the opens total.
    /// </summary>
    [MailChimpJsonProperty("opens_total")]
    public int OpensTotal { get; set; }

    /// <summary>
    /// Gets or sets the unique opens.
    /// </summary>
    [MailChimpJsonProperty("unique_opens")]
    public int UniqueOpens { get; set; }

    /// <summary>
    /// Gets or sets the proxy excluded opens.
    /// </summary>
    [MailChimpJsonProperty("proxy_excluded_opens")]
    public int ProxyExcludedOpens { get; set; }

    /// <summary>
    /// Gets or sets the proxy excluded unique opens.
    /// </summary>
    [MailChimpJsonProperty("proxy_excluded_unique_opens")]
    public int ProxyExcludedUniqueOpens { get; set; }

    /// <summary>
    /// Gets or sets the proxy excluded open rate.
    /// </summary>
    [MailChimpJsonProperty("proxy_excluded_open_rate")]
    public double ProxyExcludedOpenRate { get; set; }
}