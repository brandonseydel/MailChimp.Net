using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Interfaces;
using MailChimp.Net.Models;

namespace MailChimp.Net.Logic;

internal class ListSurveyLogic : BaseLogic, IListSurveyLogic
{
    public ListSurveyLogic(MailChimpOptions mailChimpConfiguration)
        : base(mailChimpConfiguration)
    {
    }

    public async Task<IEnumerable<Survey>> GetAllAsync(string listId, QueryableBaseRequest request = null, CancellationToken cancellationToken = default)
        => (await GetResponseAsync(listId, request, cancellationToken).ConfigureAwait(false))?.Surveys;

    public async Task<SurveyResponse> GetResponseAsync(string listId, QueryableBaseRequest request = null, CancellationToken cancellationToken = default)
    {
        request ??= new QueryableBaseRequest { Limit = _limit };
        using var client = CreateMailClient("lists/");
        var response = await client.GetAsync($"{listId}/surveys{request.ToQueryString()}", cancellationToken).ConfigureAwait(false);
        await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
        return await response.Content.ReadAsAsync<SurveyResponse>().ConfigureAwait(false);
    }

    public async Task<Survey> GetAsync(string listId, string surveyId, CancellationToken cancellationToken = default)
    {
        using var client = CreateMailClient("lists/");
        var response = await client.GetAsync($"{listId}/surveys/{surveyId}", cancellationToken).ConfigureAwait(false);
        await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
        return await response.Content.ReadAsAsync<Survey>().ConfigureAwait(false);
    }

    public async Task<Survey> AddAsync(string listId, Survey survey, CancellationToken cancellationToken = default)
    {
        using var client = CreateMailClient("lists/");
        var response = await client.PostAsJsonAsync($"{listId}/surveys", survey, cancellationToken).ConfigureAwait(false);
        await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
        return await response.Content.ReadAsAsync<Survey>().ConfigureAwait(false);
    }

    public async Task<Survey> UpdateAsync(string listId, string surveyId, Survey survey, CancellationToken cancellationToken = default)
    {
        using var client = CreateMailClient("lists/");
        var response = await client.PatchAsJsonAsync($"{listId}/surveys/{surveyId}", survey, cancellationToken).ConfigureAwait(false);
        await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
        return await response.Content.ReadAsAsync<Survey>().ConfigureAwait(false);
    }

    public async Task DeleteAsync(string listId, string surveyId, CancellationToken cancellationToken = default)
    {
        using var client = CreateMailClient("lists/");
        var response = await client.DeleteAsync($"{listId}/surveys/{surveyId}", cancellationToken).ConfigureAwait(false);
        await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
    }

    public async Task PublishAsync(string listId, string surveyId, CancellationToken cancellationToken = default)
    {
        using var client = CreateMailClient("lists/");
        var response = await client.PostAsync($"{listId}/surveys/{surveyId}/actions/publish", null, cancellationToken).ConfigureAwait(false);
        await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
    }

    public async Task UnpublishAsync(string listId, string surveyId, CancellationToken cancellationToken = default)
    {
        using var client = CreateMailClient("lists/");
        var response = await client.PostAsync($"{listId}/surveys/{surveyId}/actions/unpublish", null, cancellationToken).ConfigureAwait(false);
        await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
    }

    public async Task CreateEmailAsync(string listId, string surveyId, CancellationToken cancellationToken = default)
    {
        using var client = CreateMailClient("lists/");
        var response = await client.PostAsync($"{listId}/surveys/{surveyId}/actions/create-email", null, cancellationToken).ConfigureAwait(false);
        await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
    }

    public async Task ReplicateAsync(string listId, string surveyId, CancellationToken cancellationToken = default)
    {
        using var client = CreateMailClient("lists/");
        var response = await client.PostAsync($"{listId}/surveys/{surveyId}/actions/replicate", null, cancellationToken).ConfigureAwait(false);
        await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
    }
}
