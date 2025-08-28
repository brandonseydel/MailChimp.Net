// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Status.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.ComponentModel;

namespace MailChimp.Net.Models;

/// <summary>
/// The status.
/// </summary>
public enum Status
{
    /// <summary>
    /// The undefined.
    /// </summary>
    [Description("")]
    Undefined,

    /// <summary>
    /// The subscribed.
    /// </summary>
    [Description("subscribed")]
    Subscribed, 

    /// <summary>
    /// The unsubscribed.
    /// </summary>
    [Description("unsubscribed")]
    Unsubscribed, 

    /// <summary>
    /// The cleaned.
    /// </summary>
    [Description("cleaned")]
    Cleaned, 

    /// <summary>
    /// The pending.
    /// </summary>
    [Description("pending")]
    Pending,

    /// <summary>
    /// Trajnsaction Member status
    /// </summary>
    [Description("transactional")]
    Transactional,

    /// <summary>
    /// Archived member status
    /// </summary>
    [Description("archived")]
    Archived

}