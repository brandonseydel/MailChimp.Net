// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ReportRequest.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System;

namespace MailChimp.Net.Core
{
    /// <summary>
    /// The report request.
    /// </summary>
    public class ReportRequest : QueryableBaseRequest
    {
        /// <summary>
        /// Gets or sets the before send time.
        /// </summary>
        [QueryString("before_send_time")]
        public DateTime? BeforeSendTime { get; set; }

        /// <summary>
        /// Gets or sets the since send time.
        /// </summary>
        [QueryString("since_send_time")]
        public DateTime? SinceSendTime { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        [QueryString("type")]
        public CampaignType Type { get; set; }
    }
}