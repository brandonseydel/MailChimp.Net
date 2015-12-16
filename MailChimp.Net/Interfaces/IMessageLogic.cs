using System.Collections.Generic;
using System.Threading.Tasks;
using MailChimp.Net.Models;

namespace MailChimp.Net.Interfaces
{
    public interface IMessageLogic
    {
        Task<Message> AddAsync(string conversationId, Message member);
        Task<IEnumerable<Message>> GetAllAsync(string conversationId);
        Task<Message> GetAsync(string conversationId, string messageId);
    }
}