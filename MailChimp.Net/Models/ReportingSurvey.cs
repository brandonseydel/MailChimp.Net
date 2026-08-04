using System.Collections.Generic;
using MailChimp.Net.Core;
namespace MailChimp.Net.Models;

public class ReportingSurvey
{
    public ReportingSurvey()
    {
        Links = new HashSet<Link>();
    }

    [MailChimpJsonProperty("id")]
    public string Id { get; set; }

    [MailChimpJsonProperty("list_id")]
    public string ListId { get; set; }

    [MailChimpJsonProperty("title")]
    public string Title { get; set; }

    [MailChimpJsonProperty("status")]
    public string Status { get; set; }

    [MailChimpJsonProperty("published_at")]
    public string PublishedAt { get; set; }

    [MailChimpJsonProperty("total_responses")]
    public int TotalResponses { get; set; }

    [MailChimpJsonProperty("_links")]
    public IEnumerable<Link> Links { get; set; }
}
