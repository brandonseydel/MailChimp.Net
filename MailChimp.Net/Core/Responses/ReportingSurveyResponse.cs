using System.Collections.Generic;
using MailChimp.Net.Models;
namespace MailChimp.Net.Core;

public class ReportingSurveyResponse : BaseResponse
{
    public ReportingSurveyResponse()
    {
        Surveys = new HashSet<ReportingSurvey>();
    }

    [MailChimpJsonProperty("surveys")]
    public IEnumerable<ReportingSurvey> Surveys { get; set; }
}
