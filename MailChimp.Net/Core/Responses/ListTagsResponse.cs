using MailChimp.Net.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MailChimp.Net.Core;

public class ListTagsResponse : BaseResponse
{
    [JsonProperty("tags")]
    public IEnumerable<ListTag> Tags { get; set; }
}
