using System.Collections.Generic;
using MailChimp.Net.Models;
namespace MailChimp.Net.Core;

public class ReportingSurveyAnswerResponse : BaseResponse
{
    public ReportingSurveyAnswerResponse()
    {
        Answers = new HashSet<ReportingSurveyAnswer>();
    }

    [MailChimpJsonProperty("answers")]
    public IEnumerable<ReportingSurveyAnswer> Answers { get; set; }

    [MailChimpJsonProperty("survey_id")]
    public string SurveyId { get; set; }

    [MailChimpJsonProperty("question_id")]
    public string QuestionId { get; set; }
}
