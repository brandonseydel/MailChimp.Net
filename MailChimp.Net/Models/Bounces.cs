// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Bounces.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using Newtonsoft.Json;

namespace MailChimp.Net.Models;

/// <summary>
/// The bounces.
/// </summary>
public class Bounces
{
    /// <summary>
    /// Gets or sets the hard bounces.
    /// </summary>
    [JsonProperty("hard_bounces")]
    public int HardBounces { get; set; }

    /// <summary>
    /// Gets or sets the soft bounces.
    /// </summary>
    [JsonProperty("soft_bounces")]
    public int SoftBounces { get; set; }

    /// <summary>
    /// Gets or sets the syntax errors.
    /// </summary>
    [JsonProperty("syntax_errors")]
    public int SyntaxErrors { get; set; }
}