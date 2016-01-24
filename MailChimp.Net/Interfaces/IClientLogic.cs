using System.Collections.Generic;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Models;

namespace MailChimp.Net.Interfaces
{
    public interface IClientLogic
    {
        Task<IEnumerable<Client>> GetAllAsync(string listId, BaseRequest request);
    }
}