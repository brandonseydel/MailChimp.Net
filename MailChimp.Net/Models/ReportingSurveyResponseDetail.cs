using System.Collections.Generic;
using MailChimp.Net.Core;
namespace MailChimp.Net.Models;

public class ReportingSurveyResponseDetail
{
    public ReportingSurveyResponseDetail()
    {
        Links = new HashSet<Link>();
    }

    [MailChimpJsonProperty("response_id")]
    public string ResponseId { get; set; }

    [MailChimpJsonProperty("submitted_at")]
    public string SubmittedAt { get; set; }

    [MailChimpJsonProperty("contact")]
    public AudienceContact Contact { get; set; }

    [MailChimpJsonProperty("_links")]
    public IEnumerable<Link> Links { get; set; }
}
