using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Models;

namespace MailChimp.Net.Interfaces;

public interface IReportingLogic
{
    Task<IEnumerable<ReportingLandingPage>> GetLandingPagesAsync(QueryableBaseRequest request = null, CancellationToken cancellationToken = default);
    Task<ReportingLandingPageResponse> GetLandingPagesResponseAsync(QueryableBaseRequest request = null, CancellationToken cancellationToken = default);
    Task<ReportingLandingPage> GetLandingPageAsync(string outreachId, CancellationToken cancellationToken = default);

    Task<IEnumerable<ReportingSurvey>> GetSurveysAsync(QueryableBaseRequest request = null, CancellationToken cancellationToken = default);
    Task<ReportingSurveyResponse> GetSurveysResponseAsync(QueryableBaseRequest request = null, CancellationToken cancellationToken = default);
    Task<ReportingSurvey> GetSurveyAsync(string surveyId, CancellationToken cancellationToken = default);
    Task<IEnumerable<ReportingSurveyQuestion>> GetSurveyQuestionsAsync(string surveyId, QueryableBaseRequest request = null, CancellationToken cancellationToken = default);
    Task<ReportingSurveyQuestion> GetSurveyQuestionAsync(string surveyId, string questionId, CancellationToken cancellationToken = default);
    Task<IEnumerable<ReportingSurveyAnswer>> GetSurveyQuestionAnswersAsync(string surveyId, string questionId, QueryableBaseRequest request = null, CancellationToken cancellationToken = default);
    Task<IEnumerable<ReportingSurveyResponseDetail>> GetSurveyResponsesAsync(string surveyId, QueryableBaseRequest request = null, CancellationToken cancellationToken = default);
    Task<ReportingSurveyResponseDetail> GetSurveyResponseAsync(string surveyId, string responseId, CancellationToken cancellationToken = default);

    Task<IEnumerable<FacebookAd>> GetFacebookAdsAsync(QueryableBaseRequest request = null, CancellationToken cancellationToken = default);
    Task<FacebookAdResponse> GetFacebookAdsResponseAsync(QueryableBaseRequest request = null, CancellationToken cancellationToken = default);
    Task<FacebookAd> GetFacebookAdAsync(string outreachId, CancellationToken cancellationToken = default);
    Task<IEnumerable<EcommerceProductActivity>> GetFacebookAdEcommerceProductActivityAsync(string outreachId, QueryableBaseRequest request = null, CancellationToken cancellationToken = default);
}
