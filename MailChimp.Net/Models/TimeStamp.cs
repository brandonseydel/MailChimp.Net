// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TimeStamp.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System;

using MailChimp.Net.Core;
namespace MailChimp.Net.Models;

/// <summary>
/// The TimeStamp.
/// </summary>
public class TimeStamp
{

    /// <summary>
    /// Gets or sets the Timestamp.
    /// </summary>
    [MailChimpJsonProperty("timestamp")]
    public DateTime Timestamp { get; set; }

}
