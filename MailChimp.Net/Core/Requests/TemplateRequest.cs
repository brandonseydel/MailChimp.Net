// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TemplateRequest.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System;

namespace MailChimp.Net.Core
{
    /// <summary>
    /// The template request.
    /// </summary>
    public class TemplateRequest : BaseRequest
    {
        /// <summary>
        /// Gets or sets the before created at.
        /// </summary>
        [QueryString("before_created_at")]
        public DateTime? BeforeCreatedAt { get; set; }

        /// <summary>
        /// Gets or sets the count.
        /// </summary>
        [QueryString("count")]
        public int Count { get; set; }

        /// <summary>
        /// Gets or sets the created by.
        /// </summary>
        [QueryString("created_by")]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Gets or sets the offset.
        /// </summary>
        [QueryString("offset")]
        public int Offset { get; set; }

        /// <summary>
        /// Gets or sets the sinced created at.
        /// </summary>
        [QueryString("since_created_at")]
        public DateTime? SincedCreatedAt { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        [QueryString("type")]
        public string Type { get; set; }
    }
}