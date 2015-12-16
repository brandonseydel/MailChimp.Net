using System.Collections.Generic;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Models;

namespace MailChimp.Net.Interfaces
{
    public interface IConversationLogic
    {
        Task<IEnumerable<Conversation>> GetAllAsync(ConversationRequest request = null);
        Task<Conversation> GetAsync(string conversationId);
    }
    
}