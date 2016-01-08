using System.Collections.Generic;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Models;

namespace MailChimp.Net.Interfaces
{
    public interface IMessageLogic
    {
        Task<Message> AddAsync(string conversationId, Message member);
        Task<IEnumerable<Message>> GetAllAsync(string conversationId, MessageRequest request = null);
        Task<Message> GetAsync(string conversationId, string messageId);
    }
}