using System.Collections.Generic;
using System.Threading.Tasks;
using MailChimp.Net.Logic;
using MailChimp.Net.Models;
using MailChimp.Net.Requests;

namespace MailChimp.Net.Interfaces
{
    public interface IListLogic
    {
        Task<IEnumerable<List>> GetAllAsync(ListRequest request = null);
        Task<List> GetAsync(string id);
    }
}