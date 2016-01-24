using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Interfaces;
using MailChimp.Net.Models;

namespace MailChimp.Net.Logic
{
    public class ClientLogic : BaseLogic, IClientLogic
    {
        public ClientLogic(string apiKey) : base(apiKey)
        {
        }

        public async Task<IEnumerable<Client>> GetAllAsync(string listId, BaseRequest request)
        {
            using (var client = CreateMailClient("lists/"))
            {
                var response = await client.GetAsync($"{listId}/clients{request.ToQueryString()}");
                await response.EnsureSuccessMailChimpAsync();

                var appResponse = await response.Content.ReadAsAsync<ClientResponse>();
                return appResponse.Clients;
            }
        }
    }
}
