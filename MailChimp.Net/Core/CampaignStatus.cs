// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CampaignStatus.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.ComponentModel;

namespace MailChimp.Net.Core
{
    /// <summary>
    /// The campaign status.
    /// </summary>
    [Flags]
    public enum CampaignStatus
    {
        /// <summary>
        /// The save.
        /// </summary>
        [Description("save")]
        Save = 1, 

        /// <summary>
        /// The paused.
        /// </summary>
        [Description("paused")]
        Paused = 2, 

        /// <summary>
        /// The schedule.
        /// </summary>
        [Description("schedule")]
        Schedule = 4, 

        /// <summary>
        /// The sending.
        /// </summary>
        [Description("sending")]
        Sending = 8, 

        /// <summary>
        /// The sent.
        /// </summary>
        [Description("sent")]
        Sent = 16
    }
}