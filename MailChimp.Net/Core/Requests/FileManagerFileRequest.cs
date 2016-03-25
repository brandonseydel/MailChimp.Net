using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MailChimp.Net.Core;

namespace MailChimp.Net.Core
{
    /// <summary>
    /// The file manager file request.
    /// </summary>
    public class FileManagerFileRequest : QueryableBaseRequest
    {
        public string Type { get; set; }
        [QueryString("created_by")]
        public string CreatedBy { get; set; }
        [QueryString("before_created_at")]
        public string BeforeCreatedAt { get; set; }
        [QueryString("since_created_at")]
        public string SinceCreatedAt { get; set; }

    }
}
