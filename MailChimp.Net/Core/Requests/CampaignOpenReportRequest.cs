using System;

namespace MailChimp.Net.Core
{
    public class CampaignOpenReportRequest : QueryableBaseRequest
    {
        [QueryString("since")]
        public DateTime? Since { get; set; }
    }
}
