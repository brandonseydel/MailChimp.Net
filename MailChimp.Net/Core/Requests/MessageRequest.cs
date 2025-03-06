// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MessageRequest.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System;

namespace MailChimp.Net.Core
{
    /// <summary>
    /// The message request.
    /// </summary>
    public class MessageRequest : BaseRequest
    {
        /// <summary>
        /// Gets or sets the before timestamp.
        /// </summary>
        [QueryString("before_timestamp")]
        public DateTime? BeforeTimestamp { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether read.
        /// </summary>
        [QueryString("is_read")]
        public bool Read { get; set; }

        /// <summary>
        /// Gets or sets the since timestamp.
        /// </summary>
        [QueryString("since_timestamp")]
        public DateTime? SinceTimestamp { get; set; }
    }
}