// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Result.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.ComponentModel;

namespace MailChimp.Net.Core
{
    /// <summary>
    /// The result.
    /// </summary>
    public enum Result
    {
        /// <summary>
        /// The success.
        /// </summary>
        [Description("success")]
        Success, 

        /// <summary>
        /// The warning.
        /// </summary>
        [Description("warning")]
        Warning, 

        /// <summary>
        /// The error.
        /// </summary>
        [Description("error")]
        Error
    }
}