using System.Collections.Generic;
using System.Threading.Tasks;
using MailChimp.Net.Models;
using MailChimp.Net.Requests;

namespace MailChimp.Net.Interfaces
{
    public interface IMailChimpManager
    {
        Task<Member> AddOrUpdateListMemberAsync(string listId, Member member);
        Task<List> GetListAsync(string id);
        Task<ApiInfo> GetApiInfoAsync();
        Task<Member> GetListMemberAsync(string listId, string emailAddress);
        Task<IEnumerable<Member>> GetListMembersAsync(string listId);
        Task<IEnumerable<List>> GetListsAsync(ListRequest request = null);
        Task<IEnumerable<Campaign>> GetCampaignsAsync(CampaignRequest request = null);
        Task<Campaign> GetCampaignAsync(string campaignId);
    }
}