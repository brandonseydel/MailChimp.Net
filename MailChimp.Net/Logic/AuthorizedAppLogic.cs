using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Interfaces;
using MailChimp.Net.Models;

namespace MailChimp.Net.Logic
{
    internal class AuthorizedAppLogic : BaseLogic, IAuthorizedAppLogic
    {
        public AuthorizedAppLogic(string apiKey) : base(apiKey)
        {
        }

        public async Task<AuthorizedAppCreatedResponse> AddAsync(string clientId, string clientSecret)
        {
            using (var client = CreateMailClient("authorized-apps"))
            {
                var response = await client.PostAsJsonAsync("", new {ClientId = clientId, ClientSecret = clientSecret});
                await response.EnsureSuccessMailChimpAsync();
                return await response.Content.ReadAsAsync<AuthorizedAppCreatedResponse>();
            }
        }

        public async Task<IEnumerable<App>> GetAllAsync(AuthorizedAppRequest request = null)
        {
            using (var client = CreateMailClient("authorized-apps"))
            {
                var response = await client.GetAsync(request?.ToQueryString());
                await response.EnsureSuccessMailChimpAsync();

                var appResponse = await response.Content.ReadAsAsync<AuthorizedAppResponse>();
                return appResponse.Apps;
            }
        }

        public async Task<App> GetAsync(string appId, BaseRequest request = null)
        {
            using (var client = CreateMailClient("authorized-apps/"))
            {
                var response = await client.GetAsync($"{appId}{request?.ToQueryString()}");
                await response.EnsureSuccessMailChimpAsync();

                return await response.Content.ReadAsAsync<App>();
            }
        }
    }
}