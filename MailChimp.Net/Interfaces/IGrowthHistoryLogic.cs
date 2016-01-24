using System.Collections.Generic;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Models;

namespace MailChimp.Net.Interfaces
{
    public interface IGrowthHistoryLogic
    {
        Task<IEnumerable<History>> GetAllAsync(string listId, QueryableBaseRequest request);
        Task<History> GetAsync(string listId, string month, BaseRequest request);
    }
}