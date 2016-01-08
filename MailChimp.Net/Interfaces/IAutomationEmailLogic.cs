using System.Collections.Generic;
using System.Threading.Tasks;
using MailChimp.Net.Models;

namespace MailChimp.Net.Interfaces
{
    public interface IAutomationEmailLogic
    {
        Task<IEnumerable<Email>> GetAllAsync(string workflowId);
        Task<Email> GetAsync(string workflowId, string workflowEmailId);
        Task PauseAsync(string workflowId, string workflowEmailId);
        Task StartAsync(string workflowId, string workflowEmailId);
    }
}