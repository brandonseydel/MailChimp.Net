using System.Collections.Generic;
using System.Threading.Tasks;
using MailChimp.Net.Models;

namespace MailChimp.Net.Interfaces
{
    public interface IAutomationEmailQueueLogic
    {
        Task<Queue> AddSubscriberAsync(string workflowId, string workflowEmailId, string emailAddress);
        Task<IEnumerable<Queue>> GetAllAsync(string workflowId, string workflowEmailId);
        Task<Queue> GetAsync(string workflowId, string workflowEmailId, string emailAddress);
    }
}