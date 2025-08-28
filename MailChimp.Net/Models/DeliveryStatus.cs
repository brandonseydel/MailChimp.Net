// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DeliveryStatus.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using Newtonsoft.Json;

namespace MailChimp.Net.Models;

/// <summary>
/// The delivery status.
/// </summary>
public class DeliveryStatus
{
    /// <summary>
    /// Gets or sets a value indicating whether enabled.
    /// </summary>
    [JsonProperty("enabled")]
    public bool Enabled { get; set; }

    [JsonProperty("can_cancel")]
    public bool CanCancel { get; set; }

    [JsonProperty("status")]
    public string Status { get; set; }

    [JsonProperty("emails_sent")]
    public int EmailsSent { get; set; }

    [JsonProperty("emails_canceled")]
    public int EmailsCanceled { get; set; }
}