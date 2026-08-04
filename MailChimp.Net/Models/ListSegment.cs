using System;
using System.Collections.Generic;
using MailChimp.Net.Core;
namespace MailChimp.Net.Models;

public class ListSegment
{
    public ListSegment()
    {
        Links = new HashSet<Link>();
    }

    [MailChimpJsonProperty("id")]
    public int Id { get; set; }

    [MailChimpJsonProperty("name")]
    public string Name { get; set; }

    [MailChimpJsonProperty("member_count")]
    public int MemberCount { get; set; }

    [MailChimpJsonProperty("type")]
    public string Type { get; set; }

    [MailChimpJsonProperty("created_at")]
    public DateTime? CreatedAt { get; set; }

    [MailChimpJsonProperty("updated_at")]
    public DateTime? UpdatedAt { get; set; }

    [MailChimpJsonProperty("list_id")]
    public string ListId { get; set; }

    [MailChimpJsonProperty("_links")]
    public IEnumerable<Link> Links { get; set; }

    [MailChimpJsonProperty("options")]
    public SegmentOptions Options { get; set; }
}
