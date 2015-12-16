namespace MailChimp.Net.Core
{
    public class CampaignRequest : QueryableBaseRequest
    {
        
        [QueryString("type")]
        public CampaignType? Type { get; set; }

        [QueryString("status")]
        public CampaignStatus? Status { get; set; }
    }
}