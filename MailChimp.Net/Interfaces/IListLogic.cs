using System.Collections.Generic;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Models;

namespace MailChimp.Net.Interfaces
{
    public interface IListLogic
    {
        Task<IEnumerable<List>> GetAllAsync(ListRequest request = null);
        Task<List> GetAsync(string id);
    }
}