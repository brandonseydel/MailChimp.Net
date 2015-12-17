using System.Collections.Generic;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Core.Requests;
using MailChimp.Net.Models;

namespace MailChimp.Net.Interfaces
{
    public interface IAuthorizedAppLogic
    {
        Task<App> AddAsync(string clientId, string clientSecret);
        Task<IEnumerable<App>> GetAllAsync(AuthorizedAppRequest request = null);
        Task<App> GetAsync(string appId, BaseRequest request = null);
    }
}