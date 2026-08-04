using System.Collections.Generic;
using MailChimp.Net.Core;
namespace MailChimp.Net.Models;

public class ReportingSurveyAnswer
{
    public ReportingSurveyAnswer()
    {
        Links = new HashSet<Link>();
    }

    [MailChimpJsonProperty("id")]
    public string Id { get; set; }

    [MailChimpJsonProperty("value")]
    public string Value { get; set; }

    [MailChimpJsonProperty("count")]
    public int Count { get; set; }

    [MailChimpJsonProperty("_links")]
    public IEnumerable<Link> Links { get; set; }
}
