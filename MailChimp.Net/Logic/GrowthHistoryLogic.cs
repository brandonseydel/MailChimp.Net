using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Interfaces;
using MailChimp.Net.Models;

namespace MailChimp.Net.Logic
{
    public class GrowthHistoryLogic : BaseLogic, IGrowthHistoryLogic
    {
        public GrowthHistoryLogic(string apiKey) : base(apiKey)
        {
        }

        public async Task<IEnumerable<History>> GetAllAsync(string listId, QueryableBaseRequest request)
        {
            using (var client = CreateMailClient("lists/"))
            {
                var response = await client.GetAsync($"{listId}/growth-history{request.ToQueryString()}");
                await response.EnsureSuccessMailChimpAsync();

                var appResponse = await response.Content.ReadAsAsync<GrowthHistoryResponse>();
                return appResponse.History;
            }
        }

        public async Task<History> GetAsync(string listId, string month, BaseRequest request)
        {
            using (var client = CreateMailClient("lists/"))
            {
                var response = await client.GetAsync($"{listId}/growth-history/month{request.ToQueryString()}");
                await response.EnsureSuccessMailChimpAsync();

                return await response.Content.ReadAsAsync<History>();
            }
        }
    }
}