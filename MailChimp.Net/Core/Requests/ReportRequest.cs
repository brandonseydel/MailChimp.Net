namespace MailChimp.Net.Core
{
    public class ReportRequest : BaseRequest
    {        
        [QueryString("type")]
        public CampaignType Type { get; set; }
    }
}