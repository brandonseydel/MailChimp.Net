// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Tracking.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using MailChimp.Net.Core;

namespace MailChimp.Net.Models;

/// <summary>
/// The tracking.
/// </summary>
public class Tracking
{
    /// <summary>
    /// Gets or sets the clicktale.
    /// </summary>
    [MailChimpJsonProperty("clicktale")]
    public string Clicktale { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether ecomm 360.
    /// </summary>
    [MailChimpJsonProperty("ecomm360")]
    public bool Ecomm360 { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether goal tracking.
    /// </summary>
    [MailChimpJsonProperty("goal_tracking")]
    public bool GoalTracking { get; set; }

    /// <summary>
    /// Gets or sets the google analytics.
    /// </summary>
    [MailChimpJsonProperty("google_analytics")]
    public string GoogleAnalytics { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether html clicks.
    /// </summary>
    [MailChimpJsonProperty("html_clicks")]
    public bool HtmlClicks { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether opens.
    /// </summary>
    [MailChimpJsonProperty("opens")]
    public bool Opens { get; set; }

    [MailChimpJsonProperty("salesforce")]
    public SalesForce SalesForce { get; set; }

    [MailChimpJsonProperty("highrise")]
    public HighRise HighRise { get; set; }

    [MailChimpJsonProperty("capsule")]
    public Capsule Capsule { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether text clicks.
    /// </summary>
    [MailChimpJsonProperty("text_clicks")]
    public bool TextClicks { get; set; }
}