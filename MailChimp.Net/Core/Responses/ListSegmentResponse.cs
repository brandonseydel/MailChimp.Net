using System.Collections.Generic;
using MailChimp.Net.Models;
using Newtonsoft.Json;

namespace MailChimp.Net.Core;

public class ListSegmentResponse
{

    public ListSegmentResponse()
    {
        Segments = new HashSet<ListSegment>();
        Links = new HashSet<Link>();
    }

    [JsonProperty("segments")]
    public IEnumerable<ListSegment> Segments { get; set; }

    [JsonProperty("list_id")]
    public string ListId { get; set; }

    [JsonProperty("_links")]
    public IEnumerable<Link> Links { get; set; }

    [JsonProperty("total_items")]
    public int TotalItems { get; set; }
}
