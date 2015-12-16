using System.Collections.Generic;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Models;

namespace MailChimp.Net.Interfaces
{
    public interface ICampaignLogic
    {
        Task<IEnumerable<Campaign>> GetAll(CampaignRequest request = null);
        Task<Campaign> GetAsync(string id);
        Task CancelAsync(string campaignId);
        Task SendAsync(string campaignId);
        Task DeleteAsync(string campaignId);
        Task<Campaign> AddOrUpdateAsync(string campaignId, Campaign campaign);

    }
}