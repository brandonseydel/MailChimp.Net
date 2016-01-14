using System.Collections.Generic;
using System.Threading.Tasks;
using MailChimp.Net.Models;

namespace MailChimp.Net.Interfaces
{
    public interface IInterestCategoryLogic
    {
        Task AddAsync(InterestCategory category, string listId);
        Task UpdateAsync(InterestCategory category, string listId, string interestCategoryId);
        Task GetAllAsync(string listId);
        Task GetAsync(string listId, string interestCategoryId);

        Task DeleteAsync(string listId, string interestCatregoryId);
    }
}