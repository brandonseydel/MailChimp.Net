
using System;
using System.ComponentModel;

namespace MailChimp.Net.Core
{
    /// <summary>
    /// Sort order for sort_dir
    /// </summary>
    [Flags]
    public enum CampaignSortOrder
    {
        /// <summary>
        /// ASC
        /// </summary>
        [Description("ASC")]
        ASC = 1,
        /// <summary>
        /// ASC
        /// </summary>
        [Description("DESC")]
        DESC = 1
    }

}