using System.Collections.Generic;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Models;

namespace MailChimp.Net.Interfaces
{
    public interface IAbuseReportLogic
    {
        Task<IEnumerable<AbuseReport>> GetAllAsync(string listId, QueryableBaseRequest request);
        Task<AbuseReport> GetAsync(string listId, string reportId, QueryableBaseRequest request);
    }
}