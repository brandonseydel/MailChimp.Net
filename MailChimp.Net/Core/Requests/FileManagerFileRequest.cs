using System;

namespace MailChimp.Net.Core
{
    /// <summary>
    /// The file manager file request.
    /// </summary>
    public class FileManagerRequest : QueryableBaseRequest
    {
        [QueryString("type")]
        public string Type { get; set; }
        [QueryString("created_by")]
        public string CreatedBy { get; set; }
        [QueryString("before_created_at")]
        public DateTime? BeforeCreatedAt { get; set; }
        [QueryString("since_created_at")]
        public DateTime? SinceCreatedAt { get; set; }

    }
}
