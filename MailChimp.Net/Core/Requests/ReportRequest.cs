using System;

namespace MailChimp.Net.Core
{
    public class ReportRequest : QueryableBaseRequest
    {
        [QueryString("type")]
        public CampaignType Type { get; set; }

        [QueryString("before_send_time")]
        public DateTime? BeforeSendTime { get; set; }

        [QueryString("since_send_time")]
        public DateTime? SinceSendTime { get; set; }
    }
}