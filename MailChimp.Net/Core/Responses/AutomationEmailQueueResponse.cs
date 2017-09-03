// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AutomationEmailQueueResponse.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;

using MailChimp.Net.Models;

using Newtonsoft.Json;

namespace MailChimp.Net.Core
{
    /// <summary>
    /// The automation email queue response.
    /// </summary>
    public class AutomationEmailQueueResponse : BaseResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationEmailQueueResponse"/> class.
        /// </summary>
        public AutomationEmailQueueResponse()
        {
            Queues = new HashSet<Queue>();
            Links = new HashSet<Link>();
        }

        /// <summary>
        /// Gets or sets the email id.
        /// </summary>
        [JsonProperty("email_id")]
        public string EmailId { get; set; }

        /// <summary>
        /// Gets or sets the queues.
        /// </summary>
        [JsonProperty("queue")]
        public IEnumerable<Queue> Queues { get; set; }

        /// <summary>
        /// Gets or sets the workflow id.
        /// </summary>
        [JsonProperty("workflow_id")]
        public string WorkflowId { get; set; }
    }
}