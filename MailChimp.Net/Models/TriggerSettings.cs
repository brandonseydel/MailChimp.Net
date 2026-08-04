// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TriggerSettings.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using MailChimp.Net.Core;

namespace MailChimp.Net.Models;

/// <summary>
/// The trigger settings.
/// </summary>
public class TriggerSettings
{
    /// <summary>
    /// Gets or sets the runtime.
    /// </summary>
    [MailChimpJsonProperty("runtime")]
    public Runtime Runtime { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether send immediately.
    /// </summary>
    [MailChimpJsonProperty("send_immediately")]
    public bool SendImmediately { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether trigger on import.
    /// </summary>
    [MailChimpJsonProperty("trigger_on_import")]
    public bool TriggerOnImport { get; set; }

    /// <summary>
    /// Gets or sets the workflow emails count.
    /// </summary>
    [MailChimpJsonProperty("workflow_emails_count")]
    public int WorkflowEmailsCount { get; set; }

    /// <summary>
    /// Gets or sets the workflow type.
    /// </summary>
    [MailChimpJsonProperty("workflow_type")]
    public string WorkflowType { get; set; }
}