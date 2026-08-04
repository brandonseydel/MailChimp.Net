// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Advice.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using MailChimp.Net.Core;

namespace MailChimp.Net.Models;

/// <summary>
/// The advice.
/// </summary>
public class Advice
{
    /// <summary>
    /// Gets or sets the message.
    /// </summary>
    [MailChimpJsonProperty("message")]
    public string Message { get; set; }

    /// <summary>
    /// Gets or sets the type.
    /// </summary>
    [MailChimpJsonProperty("type")]
    public string Type { get; set; }
}