using System.Collections.Generic;
using System.Threading.Tasks;
using MailChimp.Net.Models;

namespace MailChimp.Net.Interfaces
{
    public interface IMemberLogic
    {
        Task<Member> AddOrUpdateMemberAsync(string listId, Member member);
        Task<IEnumerable<Member>> GetAllByListIdAsync(string listId);
        Task<Member> GetListMemberAsync(string listId, string emailAddress);
    }
}