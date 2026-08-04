using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Interfaces;
using MailChimp.Net.Models;

namespace MailChimp.Net.Logic;

internal class AccountExportLogic : BaseLogic, IAccountExportLogic
{
    private const string BaseUrl = "account-exports";

    public AccountExportLogic(MailChimpOptions mailChimpConfiguration)
        : base(mailChimpConfiguration)
    {
    }

    public async Task<IEnumerable<AccountExport>> GetAllAsync(QueryableBaseRequest request = null, CancellationToken cancellationToken = default)
        => (await GetResponseAsync(request, cancellationToken).ConfigureAwait(false))?.Exports;

    public async Task<AccountExportResponse> GetResponseAsync(QueryableBaseRequest request = null, CancellationToken cancellationToken = default)
    {
        request ??= new QueryableBaseRequest { Limit = _limit };
        using var client = CreateMailClient(BaseUrl);
        var response = await client.GetAsync(request.ToQueryString(), cancellationToken).ConfigureAwait(false);
        await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
        return await response.Content.ReadAsAsync<AccountExportResponse>().ConfigureAwait(false);
    }

    public async Task<AccountExport> GetAsync(string exportId, CancellationToken cancellationToken = default)
    {
        using var client = CreateMailClient($"{BaseUrl}/");
        var response = await client.GetAsync(exportId, cancellationToken).ConfigureAwait(false);
        await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
        return await response.Content.ReadAsAsync<AccountExport>().ConfigureAwait(false);
    }

    public async Task<AccountExport> AddAsync(AccountExportRequest request = null, CancellationToken cancellationToken = default)
    {
        using var client = CreateMailClient(BaseUrl);
        var response = await client.PostAsJsonAsync(string.Empty, request ?? new AccountExportRequest(), cancellationToken).ConfigureAwait(false);
        await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
        return await response.Content.ReadAsAsync<AccountExport>().ConfigureAwait(false);
    }
}
