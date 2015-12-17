using System.Collections.Generic;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Models;

namespace MailChimp.Net.Interfaces
{
    public interface IFeedbackLogic
    {
        Task<Feedback> AddOrUpdateAsync(string campaignId, Feedback feedback);
        Task<IEnumerable<Feedback>> GetAllAsync(string campaignId, FeedbackRequest request = null);
        Task<Feedback> GetAsync(string campaignId, string feedbackId);
        Task DeleteAsync(string campaignId, string feedbackId);
    }
}