using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Interfaces;
using MailChimp.Net.Models;

namespace MailChimp.Net.Logic;

internal class SmsCampaignLogic : BaseLogic, ISmsCampaignLogic
{
    private const string BaseUrl = "sms-campaigns";

    public SmsCampaignLogic(MailChimpOptions mailChimpConfiguration)
        : base(mailChimpConfiguration)
    {
    }

    public async Task<IEnumerable<SmsCampaign>> GetAllAsync(QueryableBaseRequest request = null, CancellationToken cancellationToken = default)
        => (await GetResponseAsync(request, cancellationToken).ConfigureAwait(false))?.SmsCampaigns;

    public async Task<SmsCampaignResponse> GetResponseAsync(QueryableBaseRequest request = null, CancellationToken cancellationToken = default)
    {
        request ??= new QueryableBaseRequest { Limit = _limit };
        using var client = CreateMailClient(BaseUrl);
        var response = await client.GetAsync(request.ToQueryString(), cancellationToken).ConfigureAwait(false);
        await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
        return await response.Content.ReadAsAsync<SmsCampaignResponse>().ConfigureAwait(false);
    }

    public async Task<SmsCampaign> GetAsync(string smsCampaignId, BaseRequest request = null, CancellationToken cancellationToken = default)
    {
        using var client = CreateMailClient($"{BaseUrl}/");
        var response = await client.GetAsync($"{smsCampaignId}{request?.ToQueryString()}", cancellationToken).ConfigureAwait(false);
        await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
        return await response.Content.ReadAsAsync<SmsCampaign>().ConfigureAwait(false);
    }

    public async Task<SmsCampaign> AddAsync(SmsCampaign smsCampaign, CancellationToken cancellationToken = default)
    {
        using var client = CreateMailClient(BaseUrl);
        var response = await client.PostAsJsonAsync(string.Empty, smsCampaign, cancellationToken).ConfigureAwait(false);
        await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
        return await response.Content.ReadAsAsync<SmsCampaign>().ConfigureAwait(false);
    }

    public async Task<SmsCampaign> UpdateAsync(string smsCampaignId, SmsCampaign smsCampaign, CancellationToken cancellationToken = default)
    {
        using var client = CreateMailClient($"{BaseUrl}/");
        var response = await client.PatchAsJsonAsync(smsCampaignId, smsCampaign, cancellationToken).ConfigureAwait(false);
        await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
        return await response.Content.ReadAsAsync<SmsCampaign>().ConfigureAwait(false);
    }

    public async Task DeleteAsync(string smsCampaignId, CancellationToken cancellationToken = default)
    {
        using var client = CreateMailClient($"{BaseUrl}/");
        var response = await client.DeleteAsync(smsCampaignId, cancellationToken).ConfigureAwait(false);
        await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
    }

    public async Task CancelSendAsync(string smsCampaignId, CancellationToken cancellationToken = default)
    {
        using var client = CreateMailClient($"{BaseUrl}/");
        var response = await client.PostAsync($"{smsCampaignId}/actions/cancel-send", null, cancellationToken).ConfigureAwait(false);
        await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
    }

    public async Task SendAsync(string smsCampaignId, CancellationToken cancellationToken = default)
    {
        using var client = CreateMailClient($"{BaseUrl}/");
        var response = await client.PostAsync($"{smsCampaignId}/actions/send", null, cancellationToken).ConfigureAwait(false);
        await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
    }

    public async Task ScheduleAsync(string smsCampaignId, SmsCampaignScheduleRequest request = null, CancellationToken cancellationToken = default)
    {
        using var client = CreateMailClient($"{BaseUrl}/");
        var response = await client.PostAsJsonAsync($"{smsCampaignId}/actions/schedule", request, cancellationToken).ConfigureAwait(false);
        await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
    }

    public async Task<SmsCampaignContent> GetContentAsync(string smsCampaignId, CancellationToken cancellationToken = default)
    {
        using var client = CreateMailClient($"{BaseUrl}/");
        var response = await client.GetAsync($"{smsCampaignId}/content", cancellationToken).ConfigureAwait(false);
        await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
        return await response.Content.ReadAsAsync<SmsCampaignContent>().ConfigureAwait(false);
    }

    public async Task<SmsCampaignContent> SetContentAsync(string smsCampaignId, SmsCampaignContent content, CancellationToken cancellationToken = default)
    {
        using var client = CreateMailClient($"{BaseUrl}/");
        var response = await client.PutAsJsonAsync($"{smsCampaignId}/content", content, cancellationToken).ConfigureAwait(false);
        await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
        return await response.Content.ReadAsAsync<SmsCampaignContent>().ConfigureAwait(false);
    }
}
