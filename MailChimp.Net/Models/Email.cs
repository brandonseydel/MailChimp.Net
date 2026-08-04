// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Email.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;

using MailChimp.Net.Core;
namespace MailChimp.Net.Models;

/// <summary>
/// The email.
/// </summary>
public class Email
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Email"/> class.
    /// </summary>
    public Email()
    {
        Links = new HashSet<Link>();
    }

    /// <summary>
    /// Gets or sets the archive url.
    /// </summary>
    [MailChimpJsonProperty("archive_url")]
    public string ArchiveUrl { get; set; }

    /// <summary>
    /// Gets or sets the content type.
    /// </summary>
    [MailChimpJsonProperty("content_type")]
    public string ContentType { get; set; }

    /// <summary>
    /// Gets or sets the create time.
    /// </summary>
    [MailChimpJsonProperty("create_time")]
    public string CreateTime { get; set; }

    /// <summary>
    /// Gets or sets the delay.
    /// </summary>
    [MailChimpJsonProperty("delay")]
    public Delay Delay { get; set; }

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
    /// Gets or sets the position.
    /// </summary>
    [MailChimpJsonProperty("position")]
    public int Position { get; set; }

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
    /// Gets or sets the send time.
    /// </summary>
    [MailChimpJsonProperty("send_time")]
    public string SendTime { get; set; }

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
    public string Status { get; set; }

    /// <summary>
    /// Gets or sets the tracking.
    /// </summary>
    [MailChimpJsonProperty("tracking")]
    public Tracking Tracking { get; set; }

    /// <summary>
    /// Gets or sets the workflow id.
    /// </summary>
    [MailChimpJsonProperty("workflow_id")]
    public string WorkflowId { get; set; }
    
    /// <summary>
    /// Gets or sets the web id.
    /// </summary>
    [MailChimpJsonProperty("web_id")]
    public int WebId { get; set; }
}
