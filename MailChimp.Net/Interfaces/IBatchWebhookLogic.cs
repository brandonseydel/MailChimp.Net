using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Models;

namespace MailChimp.Net.Interfaces
{
    public interface IBatchWebHookLogic
    {
        Task DeleteAsync(string batchWebHookId, CancellationToken cancellationToken = default);
        Task<BatchWebHook> UpdateAsync(string batchWebHookId, string url, CancellationToken cancellationToken = default);
        Task<BatchWebHook> AddAsync(string url, CancellationToken cancellationToken = default);
        Task<BatchWebHookResponse> GetResponseAsync(QueryableBaseRequest request = null, CancellationToken cancellationToken = default);
        Task<IEnumerable<BatchWebHook>> GetAllAsync(QueryableBaseRequest request = null, CancellationToken cancellationToken = default);
    }
}
