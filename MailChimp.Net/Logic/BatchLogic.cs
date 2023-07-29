// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BatchOperationLogic.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Interfaces;

namespace MailChimp.Net.Logic;

/// <summary>
/// The batch operation logic.
/// </summary>
internal class BatchLogic : BaseLogic, IBatchLogic
{
    public BatchLogic(MailChimpOptions mailChimpConfiguration)
        : base(mailChimpConfiguration)
    {
    }

    public async Task<Batch> AddAsync(BatchRequest request = null, CancellationToken cancellationToken = default)
    {
        using var client = CreateMailClient("batches");
        var response =
            await
                client.PostAsJsonAsync(string.Empty, request, cancellationToken)
                    .ConfigureAwait(false);
        await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
        return await response.Content.ReadAsAsync<Batch>().ConfigureAwait(false);
    }

    public async Task<IEnumerable<Batch>> GetAllAsync(QueryableBaseRequest request = null, CancellationToken cancellationToken = default)
        => (await GetResponseAsync(request, cancellationToken).ConfigureAwait(false))?.Batches;

    public async Task<BatchResponse> GetResponseAsync(QueryableBaseRequest request = null, CancellationToken cancellationToken = default)
    {
        request ??= new QueryableBaseRequest
        {
            Limit = _limit
        };

        using var client = CreateMailClient("batches");
        var response =
            await
                client.GetAsync(request.ToQueryString() ?? string.Empty, cancellationToken)
                    .ConfigureAwait(false);
        await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
        var batchResponse = await response.Content.ReadAsAsync<BatchResponse>().ConfigureAwait(false);
        return batchResponse;
    }

    public async Task DeleteAsync(string batchId, CancellationToken cancellationToken = default)
    {
        using var client = CreateMailClient("batches/");
        var response = await client.DeleteAsync($"{batchId}", cancellationToken).ConfigureAwait(false);
        await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
    }

    public async Task<Batch> GetBatchStatus(string batchId, CancellationToken cancellationToken = default)
    {
        using var client = CreateMailClient($"batches/{batchId}");
        var response =
            await
                client.GetAsync(string.Empty, cancellationToken).ConfigureAwait(false);
        await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
        var batchStatus = await response.Content.ReadAsAsync<Batch>().ConfigureAwait(false);
        return batchStatus;
    }

}