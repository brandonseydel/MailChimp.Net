using System.Collections.Generic;
using MailChimp.Net.Models;
namespace MailChimp.Net.Core;

public class ListSegmentResponse
{

    public ListSegmentResponse()
    {
        Segments = new HashSet<ListSegment>();
        Links = new HashSet<Link>();
    }

    [MailChimpJsonProperty("segments")]
    public IEnumerable<ListSegment> Segments { get; set; }

    [MailChimpJsonProperty("list_id")]
    public string ListId { get; set; }

    [MailChimpJsonProperty("_links")]
    public IEnumerable<Link> Links { get; set; }

    [MailChimpJsonProperty("total_items")]
    public int TotalItems { get; set; }
}
