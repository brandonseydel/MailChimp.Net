using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Models;

namespace MailChimp.Net.Interfaces
{
    public interface IContentLogic
    {
        Task<Content> AddOrUpdateAsync(string campaignId, ContentRequest request);
        Task<Content> GetAsync(string campaignId);
    }
}