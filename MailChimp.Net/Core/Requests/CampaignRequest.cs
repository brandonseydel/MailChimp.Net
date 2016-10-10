// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CampaignRequest.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System;

namespace MailChimp.Net.Core
{
    /// <summary>
    /// The campaign request.
    /// </summary>
    public class CampaignRequest : QueryableBaseRequest
    {
        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        [QueryString("status")]
        public CampaignStatus? Status { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        [QueryString("type")]
        public CampaignType? Type { get; set; }

        /// <summary>
        /// Gets or sets the list id.
        /// </summary>
        [QueryString("list_id")]
        public string ListId { get; set; }

        /// <summary>
        /// Gets or sets the folder id.
        /// </summary>
        [QueryString("folder_id")]
        public string FolderId { get; set; }

        /// <summary>
        /// Gets or sets the sort_field.
        /// </summary>
        [QueryString("sort_field")]
        public CampaignSortField? SortField { get; set; }

        /// <summary>
        /// Gets or sets sort_dir.
        /// </summary>
        [QueryString("sort_dir")]
        public CampaignSortOrder? SortOrder { get; set; }

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
        /// Gets or sets the before create time.
        /// </summary>
        [QueryString("before_create_time")]
        public DateTime? BeforeCreateTime { get; set; }

        /// <summary>
        /// Gets or sets the since create time.
        /// </summary>
        [QueryString("since_create_time")]
        public DateTime? SinceCreateTime { get; set; }
    }
}