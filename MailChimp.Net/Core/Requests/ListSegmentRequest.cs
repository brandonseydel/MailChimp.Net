using System;

namespace MailChimp.Net.Core
{
    public class ListSegmentRequest : QueryableBaseRequest
    {
        [QueryString("type")]
        public string Type { get; set; }
        [QueryString("created_by")]
        public string CreatedBy { get; set; }
        [QueryString("before_created_at")]
        public DateTime? BeforeCreatedAt { get; set; }
        [QueryString("since_created_at")]
        public DateTime? SinceCreatedAt { get; set; }

        [QueryString("before_updated_at")]
        public DateTime? BeforeUpdatedAt { get; set; }
        [QueryString("since_updated_at")]
        public DateTime? SinceUpdatedAt { get; set; }

    }
}
