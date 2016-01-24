using System.Collections.Generic;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Models;

namespace MailChimp.Net.Interfaces
{
    public interface IInterestLogic
    {
        Task<IEnumerable<Interest>> GetAllAsync(string listId, string interestCategoryId, QueryableBaseRequest request);
        Task<Interest> GetAsync(string listId, string interestCategoryId, string interestId, BaseRequest request);
        Task DeleteAsync(string listId, string interestCategoryId, string interestId);
        Task<Interest> UpdateAsync(Interest list);
    }
}