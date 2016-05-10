// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Feedback.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;

using Newtonsoft.Json;

// ReSharper disable UnusedAutoPropertyAccessor.Local
namespace MailChimp.Net.Models
{
    /// <summary>
    /// The feedback.
    /// </summary>
    public class Feedback
    {
        /// <summary>
        /// Gets or sets the block id.
        /// </summary>
        [JsonProperty("block_id")]
        public int BlockId { get; set; }

        /// <summary>
        /// Gets the campaign id.
        /// </summary>
        [JsonProperty("campaign_id")]
        public string CampaignId { get; set; }

        /// <summary>
        /// Gets the created at.
        /// </summary>
        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Gets the created by.
        /// </summary>
        [JsonProperty("created_by")]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Gets the feedback id.
        /// </summary>
        [JsonProperty("feedback_id")]
        public int? FeedbackId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether is complete.
        /// </summary>
        [JsonProperty("is_complete")]
        public bool IsComplete { get; set; }

        /// <summary>
        /// Gets the links.
        /// </summary>
        [JsonProperty("_links")]
        public IEnumerable<Link> Links { get; set; }

        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; }

        /// <summary>
        /// Gets the parent id.
        /// </summary>
        [JsonProperty("parent_id")]
        public int ParentId { get; set; }

        /// <summary>
        /// Gets the source.
        /// </summary>
        [JsonProperty("source")]
        public string Source { get; set; }

        /// <summary>
        /// Gets the updated at.
        /// </summary>
        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }
}