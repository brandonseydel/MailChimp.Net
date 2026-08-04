// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Stats.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using MailChimp.Net.Core;

namespace MailChimp.Net.Models;

/// <summary>
/// The stats.
/// </summary>
public class Stats
{
    /// <summary>
    /// Gets or sets the avg sub rate.
    /// </summary>
    [MailChimpJsonProperty("avg_sub_rate")]
    public double AvgSubRate { get; set; }

    /// <summary>
    /// Gets or sets the avg unsub rate.
    /// </summary>
    [MailChimpJsonProperty("avg_unsub_rate")]
    public double AvgUnsubRate { get; set; }

    /// <summary>
    /// Gets or sets the campaign count.
    /// </summary>
    [MailChimpJsonProperty("campaign_count")]
    public int CampaignCount { get; set; }

    /// <summary>
    /// Gets or sets the campaign last sent.
    /// </summary>
    [MailChimpJsonProperty("campaign_last_sent")]
    public string CampaignLastSent { get; set; }

    /// <summary>
    /// Gets or sets the cleaned count.
    /// </summary>
    [MailChimpJsonProperty("cleaned_count")]
    public int CleanedCount { get; set; }

    /// <summary>
    /// Gets or sets the cleaned count since send.
    /// </summary>
    [MailChimpJsonProperty("cleaned_count_since_send")]
    public int CleanedCountSinceSend { get; set; }

    /// <summary>
    /// Gets or sets the click rate.
    /// </summary>
    [MailChimpJsonProperty("click_rate")]
    public double ClickRate { get; set; }

    /// <summary>
    /// Gets or sets the last sub date.
    /// </summary>
    [MailChimpJsonProperty("last_sub_date")]
    public string LastSubDate { get; set; }

    /// <summary>
    /// Gets or sets the last unsub date.
    /// </summary>
    [MailChimpJsonProperty("last_unsub_date")]
    public string LastUnsubDate { get; set; }

    /// <summary>
    /// Gets or sets the member count.
    /// </summary>
    [MailChimpJsonProperty("member_count")]
    public int MemberCount { get; set; }

    /// <summary>
    /// Gets or sets the member count since send.
    /// </summary>
    [MailChimpJsonProperty("member_count_since_send")]
    public int MemberCountSinceSend { get; set; }

    /// <summary>
    /// Gets or sets the merge field count.
    /// </summary>
    [MailChimpJsonProperty("merge_field_count")]
    public int MergeFieldCount { get; set; }

    /// <summary>
    /// Gets or sets the open rate.
    /// </summary>
    [MailChimpJsonProperty("open_rate")]
    public double OpenRate { get; set; }

    /// <summary>
    /// Gets or sets the target sub rate.
    /// </summary>
    [MailChimpJsonProperty("target_sub_rate")]
    public double TargetSubRate { get; set; }

    /// <summary>
    /// Gets or sets the unsubscribe count.
    /// </summary>
    [MailChimpJsonProperty("unsubscribe_count")]
    public int UnsubscribeCount { get; set; }

    /// <summary>
    /// Gets or sets the unsubscribe count since send.
    /// </summary>
    [MailChimpJsonProperty("unsubscribe_count_since_send")]
    public int UnsubscribeCountSinceSend { get; set; }
}