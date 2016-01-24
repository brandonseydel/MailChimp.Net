using System.Collections.Generic;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Models;

namespace MailChimp.Net.Interfaces
{
    public interface INoteLogic
    {
        Task<IEnumerable<Note>> GetAllAsync(string listId, string emailAddress, QueryableBaseRequest request = null);
        Task<Note> GetAsync(string listId, string emailAddress, string noteId);
        Task DeleteAsync(string listId, string emailAddress, string noteId, BaseRequest request);
        Task<Note> AddOrUpdateAsync(string listId, string emailAddress, string noteId, string note);
    }
}