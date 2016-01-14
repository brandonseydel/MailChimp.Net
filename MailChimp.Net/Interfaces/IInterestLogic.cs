using MailChimp.Net.Core;
using MailChimp.Net.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailChimp.Net.Interfaces
{
    public interface IInterestLogic
    {
        Task GetAllAsync(QueryableBaseRequest request, string listId, string interestCategoryId);
        Task GetAsync(BaseRequest request, string listId, string interestCategoryId, string interestId);

        Task<Interest> UpdateAsync(Interest interest, string listId, string interestCategoryId);

        Task DeleteAsync(string listId, string interestCategoryId, string interestId);
    }
}
