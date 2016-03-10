// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GoalResponse.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;

using MailChimp.Net.Models;

using Newtonsoft.Json;

namespace MailChimp.Net.Core
{
    /// <summary>
    /// The goal response.
    /// </summary>
    public class GoalResponse : BaseResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GoalResponse"/> class.
        /// </summary>
        public GoalResponse()
        {
            this.Goals = new HashSet<Goal>();
        }

        /// <summary>
        /// Gets or sets the email id.
        /// </summary>
        [JsonProperty("email_id")]
        public string EmailId { get; set; }

        /// <summary>
        /// Gets or sets the goals.
        /// </summary>
        [JsonProperty("goals")]
        public IEnumerable<Goal> Goals { get; set; }

        /// <summary>
        /// Gets or sets the list id.
        /// </summary>
        [JsonProperty("list_id")]
        public string ListId { get; set; }
    }
}