using System;

namespace MailChimp.Net.Core
{
    public class MessageRequest : BaseRequest
    {
        [QueryString("before_timestamp")]
        public DateTime? BeforeTimestamp { get; set; }
        [QueryString("since_timestamp")]
        public DateTime? SinceTimestamp { get; set; }
    }
}