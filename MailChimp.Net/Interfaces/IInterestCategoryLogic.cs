using System.Collections.Generic;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Models;

namespace MailChimp.Net.Interfaces
{
    public interface IInterestCategoryLogic
    {
        Task<IEnumerable<InterestCategory>> GetAllAsync(string listId, InterestCategoryRequest request = null);

        Task<List> GetAsync(string id);

        Task DeleteAsync(string listId);
        Task<List> AddOrUpdateAsync(List list);
    }
}