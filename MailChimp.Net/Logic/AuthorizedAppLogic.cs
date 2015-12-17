using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Core.Requests;
using MailChimp.Net.Interfaces;
using MailChimp.Net.Models;

namespace MailChimp.Net.Logic
{
    public class AuthorizedAppLogic : BaseLogic, IAuthorizedAppLogic
    {
        public AuthorizedAppLogic(string apiKey) : base(apiKey) { }

        public Task<App> AddAsync(string clientId, string clientSecret)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<App>> GetAllAsync(AuthorizedAppRequest request = null)
        {
            using (var client = CreateMailClient("authorized-apps"))
            {
                var response = await client.GetAsync(request?.ToQueryString());
                response.EnsureSuccessStatusCode();

                var appResponse = await response.Content.ReadAsAsync<AuthorizedAppResponse>();
                return appResponse.Apps;
            }
        }

        public async Task<App> GetAsync(string appId, BaseRequest request = null)
        {
            using (var client = CreateMailClient("authorized-apps/"))
            {
                var response = await client.GetAsync($"{appId}{request?.ToQueryString()}");
                response.EnsureSuccessStatusCode();

                return await response.Content.ReadAsAsync<App>();
            }
        }
    }
}
