namespace MailChimp.Net.Core
{
    public class CampaignRequest : BaseRequest
    {
        
        [QueryString("type")]
        public CampaignType? Type { get; set; }

        [QueryString("status")]
        public CampaignStatus? Status { get; set; }
    }
}