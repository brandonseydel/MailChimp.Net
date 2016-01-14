using System.Collections.Generic;
using System.Threading.Tasks;
using MailChimp.Net.Models;

namespace MailChimp.Net.Interfaces
{
    public interface IGrowthHistoryLogic
    {
        Task GetAllAsync(string listId);
        Task GetAsync(string listId, string month);
    }
}