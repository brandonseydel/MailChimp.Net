using System.Collections.Generic;
using MailChimp.Net.Models;
namespace MailChimp.Net.Core;

public class ReportingSurveyResponsesResponse : BaseResponse
{
    public ReportingSurveyResponsesResponse()
    {
        Responses = new HashSet<ReportingSurveyResponseDetail>();
    }

    [MailChimpJsonProperty("responses")]
    public IEnumerable<ReportingSurveyResponseDetail> Responses { get; set; }

    [MailChimpJsonProperty("survey_id")]
    public string SurveyId { get; set; }
}
