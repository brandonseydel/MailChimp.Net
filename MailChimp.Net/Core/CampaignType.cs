// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CampaignType.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.ComponentModel;

namespace MailChimp.Net.Core
{
    /// <summary>
    /// The campaign type.
    /// </summary>
    [Flags]
    public enum CampaignType
    {
        /// <summary>
        /// The regular.
        /// </summary>
        [Description("regular")]
        Regular = 1, 

        /// <summary>
        /// The plaintext.
        /// </summary>
        [Description("plaintext")]
        Plaintext = 2, 

        /// <summary>
        /// The absplit.
        /// </summary>
        [Description("absplit")]
        Absplit = 4, 

        /// <summary>
        /// The rss.
        /// </summary>
        [Description("rss")]
        Rss = 8, 

        /// <summary>
        /// The variate.
        /// </summary>
        [Description("variate")]
        Variate = 16,

        /// <summary>
        /// The automation.
        /// </summary>
        [Description("automation")]
        Automation = 32
    }
}