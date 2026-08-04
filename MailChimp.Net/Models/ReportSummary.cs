// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ReportSummary.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using MailChimp.Net.Core;

namespace MailChimp.Net.Models;

/// <summary>
/// The report summary.
/// </summary>
public class ReportSummary
{
    /// <summary>
    /// Gets or sets the click rate.
    /// </summary>
    [MailChimpJsonProperty("click_rate")]
    public double ClickRate { get; set; }

    /// <summary>
    /// Gets or sets the clicks.
    /// </summary>
    [MailChimpJsonProperty("clicks")]
    public int Clicks { get; set; }

    /// <summary>
    /// Gets or sets the open rate.
    /// </summary>
    [MailChimpJsonProperty("open_rate")]
    public double OpenRate { get; set; }

    /// <summary>
    /// Gets or sets the opens.
    /// </summary>
    [MailChimpJsonProperty("opens")]
    public int Opens { get; set; }

    /// <summary>
    /// Gets or sets the subscriber clicks.
    /// </summary>
    [MailChimpJsonProperty("subscriber_clicks")]
    public int SubscriberClicks { get; set; }

    /// <summary>
    /// Gets or sets the unique opens.
    /// </summary>
    [MailChimpJsonProperty("unique_opens")]
    public int UniqueOpens { get; set; }       

    [MailChimpJsonProperty("ecommerce")]
    public Ecommerce Ecommerce { get; set; }

}