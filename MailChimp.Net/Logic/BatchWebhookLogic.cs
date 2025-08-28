using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Interfaces;
using MailChimp.Net.Models;

namespace MailChimp.Net.Logic;

public class BatchWebHookLogic : BaseLogic, IBatchWebHookLogic
{

    private const string BaseUrl = "batch-webhooks";

    public BatchWebHookLogic(MailChimpOptions mailChimpConfiguration)
        : base(mailChimpConfiguration)
    {
    }

    public async Task DeleteAsync(string batchWebHookId, CancellationToken cancellationToken = default)
    {
        using var client = this.CreateMailClient($"{BaseUrl}/");
        var response = await client.DeleteAsync(batchWebHookId, cancellationToken).ConfigureAwait(false);
    }

    public async Task<BatchWebHook> UpdateAsync(string batchWebHookId, string url, CancellationToken cancellationToken = default)
    {
        using var client = this.CreateMailClient($"{BaseUrl}/");
        var response = await client.PatchAsJsonAsync(batchWebHookId, new { url }, cancellationToken).ConfigureAwait(false);
        await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
        return await response.Content.ReadAsAsync<BatchWebHook>().ConfigureAwait(false);
    }

    public async Task<BatchWebHook> AddAsync(string url, CancellationToken cancellationToken = default)
    {
        using var client = this.CreateMailClient($"{BaseUrl}");
        var response = await client.PostAsJsonAsync("", new { url }, cancellationToken).ConfigureAwait(false);
        await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
        return await response.Content.ReadAsAsync<BatchWebHook>().ConfigureAwait(false);
    }

    public async Task<BatchWebHookResponse> GetResponseAsync(QueryableBaseRequest request = null, CancellationToken cancellationToken = default)
    {
        request ??= new MemberRequest
        {
            Limit = _limit
        };

        using var client = this.CreateMailClient($"{BaseUrl}");
        var response = await client.GetAsync($"{request.ToQueryString()}", cancellationToken).ConfigureAwait(false);
        await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

        var batchWebHookResponse = await response.Content.ReadAsAsync<BatchWebHookResponse>().ConfigureAwait(false);
        return batchWebHookResponse;
    }

    public async Task<IEnumerable<BatchWebHook>> GetAllAsync(QueryableBaseRequest request = null, CancellationToken cancellationToken = default) 
        => (await this.GetResponseAsync(request, cancellationToken).ConfigureAwait(false))?.WebHooks;
}
