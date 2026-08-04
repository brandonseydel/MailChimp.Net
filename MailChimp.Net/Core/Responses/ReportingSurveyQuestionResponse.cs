using System.Collections.Generic;
using MailChimp.Net.Models;
namespace MailChimp.Net.Core;

public class ReportingSurveyQuestionResponse : BaseResponse
{
    public ReportingSurveyQuestionResponse()
    {
        Questions = new HashSet<ReportingSurveyQuestion>();
    }

    [MailChimpJsonProperty("questions")]
    public IEnumerable<ReportingSurveyQuestion> Questions { get; set; }

    [MailChimpJsonProperty("survey_id")]
    public string SurveyId { get; set; }
}
