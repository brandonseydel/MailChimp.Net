// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Report.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;

using MailChimp.Net.Core;

namespace MailChimp.Net.Models;

/// <summary>
/// The report.
/// </summary>
public class Report
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Report"/> class.
    /// </summary>
    public Report()
    {
        Timeseries = new HashSet<Timesery>();
        Links = new HashSet<Link>();
    }

    /// <summary>
    /// Gets or sets the abuse reports.
    /// </summary>
    [MailChimpJsonProperty("abuse_reports")]
    public int AbuseReports { get; set; }

    /// <summary>
    /// Gets or sets the bounces.
    /// </summary>
    [MailChimpJsonProperty("bounces")]
    public Bounces Bounces { get; set; }

    /// <summary>
    /// Gets or sets the campaign title.
    /// </summary>
    [MailChimpJsonProperty("campaign_title")]
    public string CampaignTitle { get; set; }


    [MailChimpJsonProperty("subject_line")]
    public string SubjectLine { get; set; }

    /// <summary>
    /// Gets or sets the clicks.
    /// </summary>
    [MailChimpJsonProperty("clicks")]
    public Clicks Clicks { get; set; }

    /// <summary>
    /// Gets or sets the delivery status.
    /// </summary>
    [MailChimpJsonProperty("delivery_status")]
    public DeliveryStatus DeliveryStatus { get; set; }

    /// <summary>
    /// Gets or sets the emails sent.
    /// </summary>
    [MailChimpJsonProperty("emails_sent")]
    public int EmailsSent { get; set; }

    /// <summary>
    /// Gets or sets the facebook likes.
    /// </summary>
    [MailChimpJsonProperty("facebook_likes")]
    public FacebookLikes FacebookLikes { get; set; }

    /// <summary>
    /// Gets or sets the forwards.
    /// </summary>
    [MailChimpJsonProperty("forwards")]
    public Forwards Forwards { get; set; }

    /// <summary>
    /// Gets or sets the id.
    /// </summary>
    [MailChimpJsonProperty("id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or sets the industry stats.
    /// </summary>
    [MailChimpJsonProperty("industry_stats")]
    public IndustryStats IndustryStats { get; set; }

    /// <summary>
    /// Gets or sets the links.
    /// </summary>
    [MailChimpJsonProperty("_links")]
    public IEnumerable<Link> Links { get; set; }

    /// <summary>
    /// Gets or sets the list stats.
    /// </summary>
    [MailChimpJsonProperty("list_stats")]
    public ListStats ListStats { get; set; }

    /// <summary>
    /// Gets or sets the opens.
    /// </summary>
    [MailChimpJsonProperty("opens")]
    public Opens Opens { get; set; }

    /// <summary>
    /// Gets or sets the send time.
    /// </summary>
    [MailChimpJsonProperty("send_time")]
    public string SendTime { get; set; }

    /// <summary>
    /// Gets or sets the share report.
    /// </summary>
    [MailChimpJsonProperty("share_report")]
    public ShareReport ShareReport { get; set; }

    /// <summary>
    /// Gets or sets the timeseries.
    /// </summary>
    [MailChimpJsonProperty("timeseries")]
    public IEnumerable<Timesery> Timeseries { get; set; }

    /// <summary>
    /// Gets or sets the type.
    /// </summary>
    [MailChimpJsonProperty("type")]
    [MailChimpJsonConverter(MailChimpJsonConverterKind.StringEnumDescription)]
    public CampaignType Type { get; set; }

    /// <summary>
    /// Gets or sets the unsubscribed.
    /// </summary>
    [MailChimpJsonProperty("unsubscribed")]
    public int Unsubscribed { get; set; }
}