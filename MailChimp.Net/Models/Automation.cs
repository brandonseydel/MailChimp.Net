// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Automation.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;

using MailChimp.Net.Core;

namespace MailChimp.Net.Models;

/// <summary>
/// The automation.
/// </summary>
public class Automation
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Automation"/> class.
    /// </summary>
    public Automation()
    {
        Links = new HashSet<Link>();
    }

    /// <summary>
    /// Gets or sets the create time.
    /// </summary>
    [MailChimpJsonProperty("create_time")]
    public string CreateTime { get; set; }

    /// <summary>
    /// Gets or sets the emails sent.
    /// </summary>
    [MailChimpJsonProperty("emails_sent")]
    public int EmailsSent { get; set; }

    /// <summary>
    /// Gets or sets the id.
    /// </summary>
    [MailChimpJsonProperty("id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or sets the links.
    /// </summary>
    [MailChimpJsonProperty("_links")]
    public IEnumerable<Link> Links { get; set; }

    /// <summary>
    /// Gets or sets the recipients.
    /// </summary>
    [MailChimpJsonProperty("recipients")]
    public Recipient Recipients { get; set; }

    /// <summary>
    /// Gets or sets the report summary.
    /// </summary>
    [MailChimpJsonProperty("report_summary")]
    public ReportSummary ReportSummary { get; set; }

    /// <summary>
    /// Gets or sets the settings.
    /// </summary>
    [MailChimpJsonProperty("settings")]
    public Setting Settings { get; set; }

    /// <summary>
    /// Gets or sets the start time.
    /// </summary>
    [MailChimpJsonProperty("start_time")]
    public string StartTime { get; set; }

    /// <summary>
    /// Gets or sets the status.
    /// </summary>
    [MailChimpJsonProperty("status")]
		[MailChimpJsonConverter(MailChimpJsonConverterKind.StringEnumDescription)]
    public AutomationStatus Status { get; set; }

    /// <summary>
    /// Gets or sets the tracking.
    /// </summary>
    [MailChimpJsonProperty("tracking")]
    public Tracking Tracking { get; set; }

    /// <summary>
    /// Gets or sets the trigger settings.
    /// </summary>
    [MailChimpJsonProperty("trigger_settings")]
    public TriggerSettings TriggerSettings { get; set; }
}