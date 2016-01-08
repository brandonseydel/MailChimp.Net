using System;

namespace MailChimp.Net.Core
{
    public class TemplateRequest : BaseRequest
    {
        [QueryString("offset")]
        public int Offset { get; set; }

        [QueryString("count")]
        public int Count { get; set; }

        [QueryString("created_by")]
        public string CreatedBy { get; set; }

        [QueryString("since_created_at")]
        public DateTime? SincedCreatedAt { get; set; }

        [QueryString("before_created_at")]
        public DateTime? BeforeCreatedAt { get; set; }

        [QueryString("type")]
        public string Type { get; set; }
    }
}