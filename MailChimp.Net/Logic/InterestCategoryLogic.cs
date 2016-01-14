using MailChimp.Net.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailChimp.Net.Models;
using MailChimp.Net.Core;

namespace MailChimp.Net.Logic
{
    internal class InterestCategoryLogic : BaseLogic
    {
        public InterestCategoryLogic(string apiKey) : base(apiKey)
        {
        }

        public async Task<InterestCategory> AddAsync(InterestCategory category, string listId)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteAsync(string listId, string interestCatregoryId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<InterestCategory>> GetAllAsync(InterestCategoryRequest request, string listId)
        {
            throw new NotImplementedException();
        }

        public async Task<InterestCategory> GetAsync(BaseRequest request, string listId, string interestCategoryId)
        {
            throw new NotImplementedException();
        }

        public async Task<InterestCategory> UpdateAsync(InterestCategory category, string listId, string interestCategoryId)
        {
            throw new NotImplementedException();
        }
    }
}
