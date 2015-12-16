namespace MailChimp.Net.Core
{
    public class ConversationRequest : BaseRequest
    {
        [QueryString("has_unread_messages")]
        public bool HasUnreadMessages { get; set; }

        [QueryString("list_id")]
        public string ListId { get; set; }

        [QueryString("campaign_id")]
        public string CampaignId { get; set; }
    }
}