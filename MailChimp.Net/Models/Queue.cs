// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Queue.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;

using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    /// <summary>
    /// The queue.
    /// </summary>
    public class Queue
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Queue"/> class.
        /// </summary>
        public Queue()
        {
            this.Links = new HashSet<Link>();
        }

        /// <summary>
        /// Gets or sets the email address.
        /// </summary>
        [JsonProperty("email_address")]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Gets or sets the email id.
        /// </summary>
        [JsonProperty("email_id")]
        public string EmailId { get; set; }

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the links.
        /// </summary>
        [JsonProperty("_links")]
        public IEnumerable<Link> Links { get; set; }

        /// <summary>
        /// Gets or sets the list id.
        /// </summary>
        [JsonProperty("list_id")]
        public string ListId { get; set; }

        /// <summary>
        /// Gets or sets the next send.
        /// </summary>
        [JsonProperty("next_send")]
        public string NextSend { get; set; }

        /// <summary>
        /// Gets or sets the workflow id.
        /// </summary>
        [JsonProperty("workflow_id")]
        public string WorkflowId { get; set; }
    }
}