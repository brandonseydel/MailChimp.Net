// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MailChimpException.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Runtime.Serialization;

namespace MailChimp.Net.Core
{
    /// <summary>
    /// The mail chimp exception.
    /// </summary>
    public class MailChimpException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MailChimpException"/> class.
        /// </summary>
        /// <param name="info">
        /// The info.
        /// </param>
        /// <param name="context">
        /// The context.
        /// </param>
        public MailChimpException(SerializationInfo info, StreamingContext context)
        {
            this.Detail = info?.GetString("detail");
            this.Title = info?.GetString("title");
            this.Type = info?.GetString("type");
            this.Status = info?.GetInt32("status") ?? 0;
            this.Instance = info?.GetString("instance");
        }

        /// <summary>
        /// Gets or sets the detail.
        /// </summary>
        public string Detail { get; set; }

        /// <summary>
        /// Gets or sets the instance.
        /// </summary>
        public string Instance { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        public int Status { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// The get object data.
        /// </summary>
        /// <param name="info">
        /// The info.
        /// </param>
        /// <param name="context">
        /// The context.
        /// </param>
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);

            info?.AddValue("detail", this.Detail);
            info?.AddValue("title", this.Title);
            info?.AddValue("type", this.Type);
            info?.AddValue("status", this.Status);
            info?.AddValue("instance", this.Instance);
        }
    }
}