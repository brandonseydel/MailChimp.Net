using System.Collections.Generic;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Models;

namespace MailChimp.Net.Interfaces;

public interface IBatchWebHookLogic
{
    Task DeleteAsync(string batchWebHookId);
    Task<BatchWebHook> UpdateAsync(string batchWebHookId, string url);
    Task<BatchWebHook> AddAsync(string url);
    Task<BatchWebHookResponse> GetResponseAsync(QueryableBaseRequest request = null);
    Task<IEnumerable<BatchWebHook>> GetAllAsync(QueryableBaseRequest request = null);
}
