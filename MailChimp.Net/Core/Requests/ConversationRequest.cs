// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConversationRequest.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace MailChimp.Net.Core
{
    /// <summary>
    /// The conversation request.
    /// </summary>
    public class ConversationRequest : BaseRequest
    {
        /// <summary>
        /// Gets or sets the campaign id.
        /// </summary>
        [QueryString("campaign_id")]
        public string CampaignId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether has unread messages.
        /// </summary>
        [QueryString("has_unread_messages")]
        public bool HasUnreadMessages { get; set; }

        /// <summary>
        /// Gets or sets the list id.
        /// </summary>
        [QueryString("list_id")]
        public string ListId { get; set; }
    }
}