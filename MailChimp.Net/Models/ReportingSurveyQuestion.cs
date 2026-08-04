using System.Collections.Generic;
using MailChimp.Net.Core;
namespace MailChimp.Net.Models;

public class ReportingSurveyQuestion
{
    public ReportingSurveyQuestion()
    {
        Links = new HashSet<Link>();
    }

    [MailChimpJsonProperty("id")]
    public string Id { get; set; }

    [MailChimpJsonProperty("query")]
    public string Query { get; set; }

    [MailChimpJsonProperty("total_responses")]
    public int TotalResponses { get; set; }

    [MailChimpJsonProperty("_links")]
    public IEnumerable<Link> Links { get; set; }
}
