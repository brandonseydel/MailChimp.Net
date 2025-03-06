// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FeedbackResponse.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;

using MailChimp.Net.Models;

using Newtonsoft.Json;

namespace MailChimp.Net.Core
{
    /// <summary>
    /// The feed back response.
    /// </summary>
    public class FeedBackResponse : BaseResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FeedBackResponse"/> class.
        /// </summary>
        public FeedBackResponse()
        {
            Feedback = new HashSet<Feedback>();
        }

        /// <summary>
        /// Gets or sets the campaign id.
        /// </summary>
        [JsonProperty("campaign_id")]
        public string CampaignId { get; set; }

        /// <summary>
        /// Gets or sets the feedback.
        /// </summary>
        [JsonProperty("feedback")]
        public IEnumerable<Feedback> Feedback { get; set; }
    }
}