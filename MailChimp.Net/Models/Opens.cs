// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Opens.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System;
using Newtonsoft.Json;

namespace MailChimp.Net.Models;

/// <summary>
/// The opens.
/// </summary>
public class Opens
{
    /// <summary>
    /// Gets or sets the last open.
    /// </summary>
    [JsonProperty("last_open")]
    public DateTime? LastOpen { get; set; }

    /// <summary>
    /// Gets or sets the open rate.
    /// </summary>
    [JsonProperty("open_rate")]
    public double OpenRate { get; set; }

    /// <summary>
    /// Gets or sets the opens total.
    /// </summary>
    [JsonProperty("opens_total")]
    public int OpensTotal { get; set; }

    /// <summary>
    /// Gets or sets the unique opens.
    /// </summary>
    [JsonProperty("unique_opens")]
    public int UniqueOpens { get; set; }
}