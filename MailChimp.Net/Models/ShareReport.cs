// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ShareReport.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using Newtonsoft.Json;
using System.Diagnostics;

namespace MailChimp.Net.Models
{
    /// <summary>
    /// The share report.
    /// </summary>
    public class ShareReport : Base
    {
        /// <summary>
        /// Gets or sets the share password.
        /// </summary>
        [JsonProperty("share_password")]
        public string SharePassword { get; set; }

        /// <summary>
        /// Gets or sets the share url.
        /// </summary>
        [JsonProperty("share_url")]
        public string ShareUrl { get; set; }

        internal override DisplayBuilder GetDebuggerDisplayBuilder(DisplayBuilder Builder) {
            return base.GetDebuggerDisplayBuilder(Builder)
                .Data.Add(ShareUrl)
                .Postfix.AddExpression(SharePassword)
                ;
        }
    }
}