// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Timesery.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using Newtonsoft.Json;

namespace MailChimp.Net.Models;

/// <summary>
/// The timesery.
/// </summary>
public class Timesery
{
    /// <summary>
    /// Gets or sets the emails sent.
    /// </summary>
    [JsonProperty("emails_sent")]
    public int EmailsSent { get; set; }

    /// <summary>
    /// Gets or sets the recipients clicks.
    /// </summary>
    [JsonProperty("recipients_clicks")]
    public int RecipientsClicks { get; set; }

    /// <summary>
    /// Gets or sets the timestamp.
    /// </summary>
    [JsonProperty("timestamp")]
    public string Timestamp { get; set; }

    /// <summary>
    /// Gets or sets the unique opens.
    /// </summary>
    [JsonProperty("unique_opens")]
    public int UniqueOpens { get; set; }
}