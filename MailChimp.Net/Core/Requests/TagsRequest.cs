using System;
using System.Collections.Generic;
using System.Text;

namespace MailChimp.Net.Core
{
    public class TagsRequest : QueryableBaseRequest
    {
        [QueryString("list_id")]
        public string ListId { get; set; }
    }
}
