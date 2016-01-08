using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Interfaces;
using MailChimp.Net.Models;

namespace MailChimp.Net.Logic
{
    internal class ListLogic : BaseLogic, IListLogic
    {
        public ListLogic(string apiKey) : base(apiKey)
        {
        }

        public async Task<IEnumerable<List>> GetAllAsync(ListRequest request = null)
        {
            using (var client = CreateMailClient("lists"))
            {
                var response = await client.GetAsync(request?.ToQueryString());
                if (!response.IsSuccessStatusCode)
                {
                    throw (await response.Content.ReadAsStreamAsync()).Deserialize<MailChimpException>();
                }

                var listResponse = await response.Content.ReadAsAsync<ListResponse>();
                return listResponse.Lists;
            }
        }

        public async Task<List> GetAsync(string id)
        {
            using (var client = CreateMailClient("lists/"))
            {
                var response = await client.GetAsync($"{id}");
                if (!response.IsSuccessStatusCode)
                {
                    throw (await response.Content.ReadAsStreamAsync()).Deserialize<MailChimpException>();
                }
                return await response.Content.ReadAsAsync<List>();
            }
        }
    }
}