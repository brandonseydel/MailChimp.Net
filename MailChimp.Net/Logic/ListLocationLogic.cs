using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Interfaces;
using MailChimp.Net.Models;

namespace MailChimp.Net.Logic;

internal class ListLocationLogic : BaseLogic, IListLocationLogic
{
    public ListLocationLogic(MailChimpOptions mailChimpConfiguration)
        : base(mailChimpConfiguration)
    {
    }

    public async Task<IEnumerable<ListLocation>> GetAllAsync(string listId, QueryableBaseRequest request = null, CancellationToken cancellationToken = default)
        => (await GetResponseAsync(listId, request, cancellationToken).ConfigureAwait(false))?.Locations;

    public async Task<ListLocationResponse> GetResponseAsync(string listId, QueryableBaseRequest request = null, CancellationToken cancellationToken = default)
    {
        request ??= new QueryableBaseRequest { Limit = _limit };
        using var client = CreateMailClient("lists/");
        var response = await client.GetAsync($"{listId}/locations{request.ToQueryString()}", cancellationToken).ConfigureAwait(false);
        await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
        return await response.Content.ReadAsAsync<ListLocationResponse>().ConfigureAwait(false);
    }
}
