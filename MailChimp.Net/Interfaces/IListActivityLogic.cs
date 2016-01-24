using System.Collections.Generic;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Models;

namespace MailChimp.Net.Interfaces
{
    public interface IListActivityLogic
    {
        Task<IEnumerable<Activity>> GetAllAsync(string listId, BaseRequest request);
    }
}