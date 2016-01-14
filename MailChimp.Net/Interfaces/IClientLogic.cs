using System.Collections.Generic;
using System.Threading.Tasks;
using MailChimp.Net.Models;

namespace MailChimp.Net.Interfaces
{
    public interface IClientLogic
    {
        Task GetAllRecentAsync(string listId);
    }
}