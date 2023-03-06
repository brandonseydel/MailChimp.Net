// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Delay.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using Newtonsoft.Json;

namespace MailChimp.Net.Models;

/// <summary>
/// The delay.
/// </summary>
public class Delay
{
    /// <summary>
    /// Gets or sets the action.
    /// </summary>
    [JsonProperty("action")]
    public string Action { get; set; }

    /// <summary>
    /// Gets or sets the amount.
    /// </summary>
    [JsonProperty("amount")]
    public int Amount { get; set; }

    /// <summary>
    /// Gets or sets the direction.
    /// </summary>
    [JsonProperty("direction")]
    public string Direction { get; set; }

    /// <summary>
    /// Gets or sets the type.
    /// </summary>
    [JsonProperty("type")]
    public string Type { get; set; }
}