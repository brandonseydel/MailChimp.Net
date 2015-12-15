using System.Collections.Generic;
using System.Threading.Tasks;
using MailChimp.Net.Logic;
using MailChimp.Net.Models;

namespace MailChimp.Net.Interfaces
{
    public interface IListLogic
    {
        Task<IEnumerable<List>> GetAll(ListRequest request = null);
        Task<List> GetAsync(string id);
    }
}