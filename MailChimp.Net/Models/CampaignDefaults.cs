// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CampaignDefaults.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using Newtonsoft.Json;

namespace MailChimp.Net.Models;

/// <summary>
/// The campaign defaults.
/// </summary>
public class CampaignDefaults
{
    /// <summary>
    /// Gets or sets the from email.
    /// </summary>
    [JsonProperty("from_email")]
    public string FromEmail { get; set; }

    /// <summary>
    /// Gets or sets the from name.
    /// </summary>
    [JsonProperty("from_name")]
    public string FromName { get; set; }

    /// <summary>
    /// Gets or sets the language.
    /// </summary>
    [JsonProperty("language")]
    public string Language { get; set; }

    /// <summary>
    /// Gets or sets the subject.
    /// </summary>
    [JsonProperty("subject")]
    public string Subject { get; set; }
}