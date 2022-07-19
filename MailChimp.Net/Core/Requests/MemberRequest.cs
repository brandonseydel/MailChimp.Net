// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MemberRequest.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using MailChimp.Net.Models;

namespace MailChimp.Net.Core
{
    /// <summary>
    /// The member request.
    /// </summary>
    public class MemberRequest : QueryableBaseRequest
    {
        [QueryString("email_type")]
        public string EmailType { get; set; }

        [QueryString("unique_email_id")]
        public string UniqueEmailId { get; set; }

        [QueryString("vip_only")]
        public bool VipOnly { get; set; }

        [QueryString("status")]
        public Status? Status { get; set; }

        [QueryString("since_timestamp_opt")]
        public string SinceTimestamp { get; set; }

        [QueryString("before_timestamp_opt")]
        public string BeforeTimestamp { get; set; }

        [QueryString("since_last_changed")]
        public string SinceLastChanged { get; set; }

        [QueryString("before_last_changed")]
        public string BeforeLastChanged { get; set; }
        
        //as documented at: https://developer.mailchimp.com/documentation/mailchimp/reference/lists/members/#%20
        // to filter members by interests, 3 fields (below) are required
        [QueryString("interest_category_id")]
        public string InterestCategoryId { get; set; }

        [QueryString("interest_ids")]
        public string InterestIds { get; set; }

        [QueryString("interest_match")]
        public string InterestMatch { get; set; }

        /// <summary>
        /// Gets or sets the sort_field.
        /// </summary>
        [QueryString("sort_field")]
        public CampaignSortField? SortField { get; set; }

        /// <summary>
        /// Gets or sets sort_dir.
        /// </summary>
        [QueryString("sort_dir")]
        public MemberSortOrder? SortOrder { get; set; }

        [QueryString("since_last_campaign")]
        public bool SinceLastCampaign { get; set; }

        [QueryString("unsubscribed_since")]
        public string UnsubscribedSince { get; set; }
    }
}
