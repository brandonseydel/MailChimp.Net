// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Hours.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using Newtonsoft.Json;

namespace MailChimp.Net.Models;

/// <summary>
/// The hours.
/// </summary>
public class Hours
{
    /// <summary>
    /// Gets or sets the send at.
    /// </summary>
    [JsonProperty("send_at")]
    public string SendAt { get; set; }
}