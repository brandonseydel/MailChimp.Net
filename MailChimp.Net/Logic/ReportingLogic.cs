using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Interfaces;
using MailChimp.Net.Models;

namespace MailChimp.Net.Logic;

internal class ReportingLogic : BaseLogic, IReportingLogic
{
    public ReportingLogic(MailChimpOptions mailChimpConfiguration)
        : base(mailChimpConfiguration)
    {
    }

    public async Task<IEnumerable<ReportingLandingPage>> GetLandingPagesAsync(QueryableBaseRequest request = null, CancellationToken cancellationToken = default)
        => (await GetLandingPagesResponseAsync(request, cancellationToken).ConfigureAwait(false))?.LandingPages;

    public async Task<ReportingLandingPageResponse> GetLandingPagesResponseAsync(QueryableBaseRequest request = null, CancellationToken cancellationToken = default)
    {
        request ??= new QueryableBaseRequest { Limit = _limit };
        using var client = CreateMailClient("reporting/landing-pages");
        var response = await client.GetAsync(request.ToQueryString(), cancellationToken).ConfigureAwait(false);
        await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
        return await response.Content.ReadAsAsync<ReportingLandingPageResponse>().ConfigureAwait(false);
    }

    public async Task<ReportingLandingPage> GetLandingPageAsync(string outreachId, CancellationToken cancellationToken = default)
    {
        using var client = CreateMailClient("reporting/landing-pages/");
        var response = await client.GetAsync(outreachId, cancellationToken).ConfigureAwait(false);
        await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
        return await response.Content.ReadAsAsync<ReportingLandingPage>().ConfigureAwait(false);
    }

    public async Task<IEnumerable<ReportingSurvey>> GetSurveysAsync(QueryableBaseRequest request = null, CancellationToken cancellationToken = default)
        => (await GetSurveysResponseAsync(request, cancellationToken).ConfigureAwait(false))?.Surveys;

    public async Task<ReportingSurveyResponse> GetSurveysResponseAsync(QueryableBaseRequest request = null, CancellationToken cancellationToken = default)
    {
        request ??= new QueryableBaseRequest { Limit = _limit };
        using var client = CreateMailClient("reporting/surveys");
        var response = await client.GetAsync(request.ToQueryString(), cancellationToken).ConfigureAwait(false);
        await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
        return await response.Content.ReadAsAsync<ReportingSurveyResponse>().ConfigureAwait(false);
    }

    public async Task<ReportingSurvey> GetSurveyAsync(string surveyId, CancellationToken cancellationToken = default)
    {
        using var client = CreateMailClient("reporting/surveys/");
        var response = await client.GetAsync(surveyId, cancellationToken).ConfigureAwait(false);
        await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
        return await response.Content.ReadAsAsync<ReportingSurvey>().ConfigureAwait(false);
    }

    public async Task<IEnumerable<ReportingSurveyQuestion>> GetSurveyQuestionsAsync(string surveyId, QueryableBaseRequest request = null, CancellationToken cancellationToken = default)
    {
        request ??= new QueryableBaseRequest { Limit = _limit };
        using var client = CreateMailClient("reporting/surveys/");
        var response = await client.GetAsync($"{surveyId}/questions{request.ToQueryString()}", cancellationToken).ConfigureAwait(false);
        await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
        var result = await response.Content.ReadAsAsync<ReportingSurveyQuestionResponse>().ConfigureAwait(false);
        return result?.Questions;
    }

    public async Task<ReportingSurveyQuestion> GetSurveyQuestionAsync(string surveyId, string questionId, CancellationToken cancellationToken = default)
    {
        using var client = CreateMailClient("reporting/surveys/");
        var response = await client.GetAsync($"{surveyId}/questions/{questionId}", cancellationToken).ConfigureAwait(false);
        await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
        return await response.Content.ReadAsAsync<ReportingSurveyQuestion>().ConfigureAwait(false);
    }

    public async Task<IEnumerable<ReportingSurveyAnswer>> GetSurveyQuestionAnswersAsync(string surveyId, string questionId, QueryableBaseRequest request = null, CancellationToken cancellationToken = default)
    {
        request ??= new QueryableBaseRequest { Limit = _limit };
        using var client = CreateMailClient("reporting/surveys/");
        var response = await client.GetAsync($"{surveyId}/questions/{questionId}/answers{request.ToQueryString()}", cancellationToken).ConfigureAwait(false);
        await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
        var result = await response.Content.ReadAsAsync<ReportingSurveyAnswerResponse>().ConfigureAwait(false);
        return result?.Answers;
    }

    public async Task<IEnumerable<ReportingSurveyResponseDetail>> GetSurveyResponsesAsync(string surveyId, QueryableBaseRequest request = null, CancellationToken cancellationToken = default)
    {
        request ??= new QueryableBaseRequest { Limit = _limit };
        using var client = CreateMailClient("reporting/surveys/");
        var response = await client.GetAsync($"{surveyId}/responses{request.ToQueryString()}", cancellationToken).ConfigureAwait(false);
        await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
        var result = await response.Content.ReadAsAsync<ReportingSurveyResponsesResponse>().ConfigureAwait(false);
        return result?.Responses;
    }

    public async Task<ReportingSurveyResponseDetail> GetSurveyResponseAsync(string surveyId, string responseId, CancellationToken cancellationToken = default)
    {
        using var client = CreateMailClient("reporting/surveys/");
        var response = await client.GetAsync($"{surveyId}/responses/{responseId}", cancellationToken).ConfigureAwait(false);
        await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
        return await response.Content.ReadAsAsync<ReportingSurveyResponseDetail>().ConfigureAwait(false);
    }

    public async Task<IEnumerable<FacebookAd>> GetFacebookAdsAsync(QueryableBaseRequest request = null, CancellationToken cancellationToken = default)
        => (await GetFacebookAdsResponseAsync(request, cancellationToken).ConfigureAwait(false))?.FacebookAds;

    public async Task<FacebookAdResponse> GetFacebookAdsResponseAsync(QueryableBaseRequest request = null, CancellationToken cancellationToken = default)
    {
        request ??= new QueryableBaseRequest { Limit = _limit };
        using var client = CreateMailClient("reporting/facebook-ads");
        var response = await client.GetAsync(request.ToQueryString(), cancellationToken).ConfigureAwait(false);
        await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
        return await response.Content.ReadAsAsync<FacebookAdResponse>().ConfigureAwait(false);
    }

    public async Task<FacebookAd> GetFacebookAdAsync(string outreachId, CancellationToken cancellationToken = default)
    {
        using var client = CreateMailClient("reporting/facebook-ads/");
        var response = await client.GetAsync(outreachId, cancellationToken).ConfigureAwait(false);
        await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
        return await response.Content.ReadAsAsync<FacebookAd>().ConfigureAwait(false);
    }

    public async Task<IEnumerable<EcommerceProductActivity>> GetFacebookAdEcommerceProductActivityAsync(string outreachId, QueryableBaseRequest request = null, CancellationToken cancellationToken = default)
    {
        request ??= new QueryableBaseRequest { Limit = _limit };
        using var client = CreateMailClient("reporting/facebook-ads/");
        var response = await client.GetAsync($"{outreachId}/ecommerce-product-activity{request.ToQueryString()}", cancellationToken).ConfigureAwait(false);
        await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
        var activityResponse = await response.Content.ReadAsAsync<EcommerceProductActivityResponse>().ConfigureAwait(false);
        return activityResponse?.Products;
    }
}
