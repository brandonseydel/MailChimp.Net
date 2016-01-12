using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Models;

namespace MailChimp.Net.Interfaces
{
    public interface IAutomationLogic
    {
        Task<IEnumerable<Automation>> GetAllAsync(BaseRequest request = null);
        Task<Automation> GetAsync(string workflowId);
        Task PauseAsync(string workflowId);
        Task StartAsync(string workflowId);
    }
}
