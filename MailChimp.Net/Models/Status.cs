// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Status.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.ComponentModel;

namespace MailChimp.Net.Models
{
    /// <summary>
    /// The status.
    /// </summary>
    public enum Status
    {

        [Description("")]
        None,
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
        Pending
    }
}