// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Delay.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using MailChimp.Net.Core;

namespace MailChimp.Net.Models;

/// <summary>
/// The delay.
/// </summary>
public class Delay
{
    /// <summary>
    /// Gets or sets the action.
    /// </summary>
    [MailChimpJsonProperty("action")]
    public string Action { get; set; }

    /// <summary>
    /// Gets or sets the amount.
    /// </summary>
    [MailChimpJsonProperty("amount")]
    public int Amount { get; set; }

    /// <summary>
    /// Gets or sets the direction.
    /// </summary>
    [MailChimpJsonProperty("direction")]
    public string Direction { get; set; }

    /// <summary>
    /// Gets or sets the type.
    /// </summary>
    [MailChimpJsonProperty("type")]
    public string Type { get; set; }
}