using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Interfaces;
using MailChimp.Net.Models;

namespace MailChimp.Net.Logic;

internal class AudienceLogic : BaseLogic, IAudienceLogic
{
    private const string BaseUrl = "audiences";

    public AudienceLogic(MailChimpOptions mailChimpConfiguration)
        : base(mailChimpConfiguration)
    {
    }

    public async Task<IEnumerable<Audience>> GetAllAsync(QueryableBaseRequest request = null, CancellationToken cancellationToken = default)
        => (await GetResponseAsync(request, cancellationToken).ConfigureAwait(false))?.Audiences;

    public async Task<AudienceResponse> GetResponseAsync(QueryableBaseRequest request = null, CancellationToken cancellationToken = default)
    {
        request ??= new QueryableBaseRequest { Limit = _limit };
        using var client = CreateMailClient(BaseUrl);
        var response = await client.GetAsync(request.ToQueryString(), cancellationToken).ConfigureAwait(false);
        await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
        return await response.Content.ReadAsAsync<AudienceResponse>().ConfigureAwait(false);
    }

    public async Task<Audience> GetAsync(string audienceId, CancellationToken cancellationToken = default)
    {
        using var client = CreateMailClient($"{BaseUrl}/");
        var response = await client.GetAsync(audienceId, cancellationToken).ConfigureAwait(false);
        await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
        return await response.Content.ReadAsAsync<Audience>().ConfigureAwait(false);
    }

    public async Task<IEnumerable<AudienceContact>> GetContactsAsync(string audienceId, QueryableBaseRequest request = null, CancellationToken cancellationToken = default)
        => (await GetContactsResponseAsync(audienceId, request, cancellationToken).ConfigureAwait(false))?.Contacts;

    public async Task<AudienceContactResponse> GetContactsResponseAsync(string audienceId, QueryableBaseRequest request = null, CancellationToken cancellationToken = default)
    {
        request ??= new QueryableBaseRequest { Limit = _limit };
        using var client = CreateMailClient($"{BaseUrl}/");
        var response = await client.GetAsync($"{audienceId}/contacts{request.ToQueryString()}", cancellationToken).ConfigureAwait(false);
        await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
        return await response.Content.ReadAsAsync<AudienceContactResponse>().ConfigureAwait(false);
    }

    public async Task<AudienceContact> GetContactAsync(string audienceId, string contactId, CancellationToken cancellationToken = default)
    {
        using var client = CreateMailClient($"{BaseUrl}/");
        var response = await client.GetAsync($"{audienceId}/contacts/{contactId}", cancellationToken).ConfigureAwait(false);
        await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
        return await response.Content.ReadAsAsync<AudienceContact>().ConfigureAwait(false);
    }

    public async Task<AudienceContact> AddContactAsync(string audienceId, AudienceContact contact, CancellationToken cancellationToken = default)
    {
        using var client = CreateMailClient($"{BaseUrl}/");
        var response = await client.PostAsJsonAsync($"{audienceId}/contacts", contact, cancellationToken).ConfigureAwait(false);
        await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
        return await response.Content.ReadAsAsync<AudienceContact>().ConfigureAwait(false);
    }

    public async Task<AudienceContact> UpdateContactAsync(string audienceId, string contactId, AudienceContact contact, CancellationToken cancellationToken = default)
    {
        using var client = CreateMailClient($"{BaseUrl}/");
        var response = await client.PatchAsJsonAsync($"{audienceId}/contacts/{contactId}", contact, cancellationToken).ConfigureAwait(false);
        await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
        return await response.Content.ReadAsAsync<AudienceContact>().ConfigureAwait(false);
    }

    public async Task ArchiveContactAsync(string audienceId, string contactId, CancellationToken cancellationToken = default)
    {
        using var client = CreateMailClient($"{BaseUrl}/");
        var response = await client.PostAsync($"{audienceId}/contacts/{contactId}/actions/archive", null, cancellationToken).ConfigureAwait(false);
        await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
    }

    public async Task ForgetContactAsync(string audienceId, string contactId, CancellationToken cancellationToken = default)
    {
        using var client = CreateMailClient($"{BaseUrl}/");
        var response = await client.PostAsync($"{audienceId}/contacts/{contactId}/actions/forget", null, cancellationToken).ConfigureAwait(false);
        await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
    }
}
