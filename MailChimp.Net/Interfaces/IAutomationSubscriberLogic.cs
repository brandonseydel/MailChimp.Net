using System.Collections.Generic;
using System.Threading.Tasks;
using MailChimp.Net.Models;

namespace MailChimp.Net.Interfaces
{
    public interface IAutomationSubscriberLogic
    {
        Task<IEnumerable<Subscriber>> GetRemovedSubscribersAsync(string workflowId);
        Task<Subscriber> RemoveSubscriberAsync(string workflowId, string emailAddress);
    }
}