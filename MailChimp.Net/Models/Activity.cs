// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Activity.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using MailChimp.Net.Core;

namespace MailChimp.Net.Models;

/// <summary>
/// The activity.
/// </summary>
public class Activity
{
    /// <summary>
    /// Gets or sets the action.
    /// </summary>
    [MailChimpJsonProperty("action")]
    public string Action { get; set; }

    /// <summary>
    /// If the action is a ‘bounce’, the type of bounce received: ‘hard’, ‘soft’. (WHEN ACTIVITY IS INSTANTIATED FROM EMAILACTIVITY)
    /// </summary>
    [MailChimpJsonProperty("type")]
    public string Type { get; set; }

    /// <summary>
    /// Gets or sets the campaign id.
    /// </summary>
    [MailChimpJsonProperty("campaign_id")]
    public string CampaignId { get; set; }

    /// <summary>
    /// Gets or sets the timestamp.
    /// </summary>
    [MailChimpJsonProperty("timestamp")]
    public string Timestamp { get; set; }

    /// <summary>
    /// Gets or sets the title.
    /// </summary>
    [MailChimpJsonProperty("title")]
    public string Title { get; set; }
}