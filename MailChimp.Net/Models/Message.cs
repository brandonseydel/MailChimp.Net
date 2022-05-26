// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Message.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using Newtonsoft.Json;
using System.Diagnostics;

namespace MailChimp.Net.Models
{
    /// <summary>
    /// The message.
    /// </summary>
    public class Message : Base, IId<string>
    {
        /// <summary>
        /// Gets or sets the body.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the body.
        /// </summary>
        [JsonProperty("message")]
        public string Body { get; set; }

        /// <summary>
        /// Gets or sets the from email.
        /// </summary>
        [JsonProperty("from_email")]
        public string FromEmail { get; set; }

        /// <summary>
        /// Gets or sets the from label.
        /// </summary>
        [JsonProperty("from_label")]
        public string FromLabel { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether read.
        /// </summary>
        [JsonProperty("read")]
        public bool Read { get; set; }

        /// <summary>
        /// Gets or sets the subject.
        /// </summary>
        [JsonProperty("subject")]
        public string Subject { get; set; }

        /// <summary>
        /// Gets or sets the timestamp.
        /// </summary>
        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        internal override DisplayBuilder GetDebuggerDisplayBuilder(DisplayBuilder Builder) {
            return base.GetDebuggerDisplayBuilder(Builder)
                .Id.Add(Id)
                .Data.Add(Subject)
                ;
        }
    }
}