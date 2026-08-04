// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Domain.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using MailChimp.Net.Core;

namespace MailChimp.Net.Models;

/// <summary>
/// The domain.
/// </summary>
public class Domain
{
    /// <summary>
    /// Gets or sets the bounces.
    /// </summary>
    [MailChimpJsonProperty("bounces")]
    public int Bounces { get; set; }

    /// <summary>
    /// Gets or sets the bounces pct.
    /// </summary>
    [MailChimpJsonProperty("bounces_pct")]
    public int BouncesPct { get; set; }

    /// <summary>
    /// Gets or sets the clicks.
    /// </summary>
    [MailChimpJsonProperty("clicks")]
    public int Clicks { get; set; }

    /// <summary>
    /// Gets or sets the clicks pct.
    /// </summary>
    [MailChimpJsonProperty("clicks_pct")]
    public int ClicksPct { get; set; }

    /// <summary>
    /// Gets or sets the delivered.
    /// </summary>
    [MailChimpJsonProperty("delivered")]
    public int Delivered { get; set; }

    /// <summary>
    /// Gets or sets the domain name.
    /// </summary>
    [MailChimpJsonProperty("domain")]
    public string DomainName { get; set; }

    /// <summary>
    /// Gets or sets the emails pct.
    /// </summary>
    [MailChimpJsonProperty("emails_pct")]
    public int EmailsPct { get; set; }

    /// <summary>
    /// Gets or sets the emails sent.
    /// </summary>
    [MailChimpJsonProperty("emails_sent")]
    public int EmailsSent { get; set; }

    /// <summary>
    /// Gets or sets the opens.
    /// </summary>
    [MailChimpJsonProperty("opens")]
    public int Opens { get; set; }

    /// <summary>
    /// Gets or sets the opens pct.
    /// </summary>
    [MailChimpJsonProperty("opens_pct")]
    public int OpensPct { get; set; }

    /// <summary>
    /// Gets or sets the unsubs.
    /// </summary>
    [MailChimpJsonProperty("unsubs")]
    public int Unsubs { get; set; }

    /// <summary>
    /// Gets or sets the unsubs pct.
    /// </summary>
    [MailChimpJsonProperty("unsubs_pct")]
    public int UnsubsPct { get; set; }
}