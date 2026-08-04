// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Campaign.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System;
using MailChimp.Net.Core;
namespace MailChimp.Net.Models;

/// <summary>
/// The campaign.
/// </summary>
public class Campaign
{
    /// <summary>
    /// Gets or sets the archive url.
    /// </summary>
    [MailChimpJsonProperty("archive_url")]
    public string ArchiveUrl { get; set; }

    /// <summary>
    /// Gets or sets the long archive url.
    /// </summary>
    [MailChimpJsonProperty("long_archive_url")]
    public string LongArchiveUrl { get; set; }

    /// <summary>
    /// Gets or sets the content type.
    /// </summary>
    [MailChimpJsonProperty("content_type")]
    public string ContentType { get; set; }

    /// <summary>
    /// Gets or sets the create time.
    /// </summary>
    [MailChimpJsonProperty("create_time")]
    public DateTime CreateTime { get; set; }

    /// <summary>
    /// Gets or sets the delivery status.
    /// </summary>
    [MailChimpJsonProperty("delivery_status")]
    public DeliveryStatus DeliveryStatus { get; set; }

    [MailChimpJsonProperty("rss_opts")]
    public RssOptions RssOptions { get; set; }

    [MailChimpJsonProperty("social_card")]
    public SocialCard SocialCard { get; set; }

    [MailChimpJsonProperty("report_summary")]
    public ReportSummary ReportSummary { get; set; }

    /// <summary>
    /// Gets or sets the emails sent.
    /// </summary>
    [MailChimpJsonProperty("emails_sent")]
    public int? EmailsSent { get; set; }

    /// <summary>
    /// Gets or sets the id.
    /// </summary>
    [MailChimpJsonProperty("id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or sets the web id.
    /// </summary>
    [MailChimpJsonProperty("web_id")]
    public int WebId { get; set; }

    /// <summary>
    /// Gets or sets the links.
    /// </summary>
    [MailChimpJsonProperty("_links")]
    public Link[] Links { get; set; }

    /// <summary>
    /// Gets or sets the recipients.
    /// </summary>
    [MailChimpJsonProperty("recipients")]
    public Recipient Recipients { get; set; }

    /// <summary>
    /// Gets or sets the send time.
    /// </summary>
    [MailChimpJsonProperty("send_time")]
    public DateTime? SendTime { get; set; }

    /// <summary>
    /// Gets or sets the settings.
    /// </summary>
    [MailChimpJsonProperty("settings")]
    public Setting Settings { get; set; }

    /// <summary>
    /// Gets or sets the status.
    /// </summary>
    [MailChimpJsonProperty("status")]
    public string Status { get; set; }

    /// <summary>
    /// Gets or sets the tracking.
    /// </summary>
    [MailChimpJsonProperty("tracking")]
    public Tracking Tracking { get; set; }

    /// <summary>
    /// Gets or sets the type.
    /// </summary>
    [MailChimpJsonProperty("type")]
    [MailChimpJsonConverter(MailChimpJsonConverterKind.StringEnumDescription)]
    public CampaignType Type { get; set; }

    [MailChimpJsonProperty("dashboard_link")]
    public string DashboardLink { get; internal set; }

    [MailChimpJsonProperty("variate_settings")]
    public VariateSettings VariateSettings { get; set; }
}
