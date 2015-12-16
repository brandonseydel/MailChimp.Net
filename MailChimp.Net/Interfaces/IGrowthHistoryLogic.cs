using System.Collections.Generic;
using System.Threading.Tasks;
using MailChimp.Net.Models;

namespace MailChimp.Net.Interfaces
{
    public interface IGrowthHistoryLogic
    {
        Task<Member> AddOrUpdateAsync(string listId, Member member);
        Task<IEnumerable<Member>> GetAllAsync(string listId);
        Task<Member> GetAsync(string listId, string emailAddress);
    }
}