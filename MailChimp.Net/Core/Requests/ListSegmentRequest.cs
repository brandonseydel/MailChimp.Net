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
        public string BeforeCreatedAt { get; set; }
        [QueryString("since_created_at")]
        public string SinceCreatedAt { get; set; }

        [QueryString("before_updated_at")]
        public string BeforeUpdatedAt { get; set; }
        [QueryString("since_updated_at")]
        public string SinceUpdatedAt { get; set; }

    }
}
