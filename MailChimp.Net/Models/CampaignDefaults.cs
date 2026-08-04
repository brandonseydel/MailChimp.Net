// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CampaignDefaults.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using MailChimp.Net.Core;

namespace MailChimp.Net.Models;

/// <summary>
/// The campaign defaults.
/// </summary>
public class CampaignDefaults
{
    /// <summary>
    /// Gets or sets the from email.
    /// </summary>
    [MailChimpJsonProperty("from_email")]
    public string FromEmail { get; set; }

    /// <summary>
    /// Gets or sets the from name.
    /// </summary>
    [MailChimpJsonProperty("from_name")]
    public string FromName { get; set; }

    /// <summary>
    /// Gets or sets the language.
    /// </summary>
    [MailChimpJsonProperty("language")]
    public string Language { get; set; }

    /// <summary>
    /// Gets or sets the subject.
    /// </summary>
    [MailChimpJsonProperty("subject")]
    public string Subject { get; set; }
}