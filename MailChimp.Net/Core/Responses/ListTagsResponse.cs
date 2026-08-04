using MailChimp.Net.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MailChimp.Net.Core;

public class ListTagsResponse : BaseResponse
{
    [MailChimpJsonProperty("tags")]
    public IEnumerable<ListTag> Tags { get; set; }
}
