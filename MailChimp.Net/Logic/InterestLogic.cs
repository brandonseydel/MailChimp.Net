using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Interfaces;
using MailChimp.Net.Models;

namespace MailChimp.Net.Logic
{
    public class InterestLogic : BaseLogic, IInterestLogic
    {
        public InterestLogic(string apiKey) : base(apiKey)
        {
        }

        public async Task<IEnumerable<Interest>> GetAllAsync(string listId, string interestCategoryId,
            QueryableBaseRequest request)
        {
            using (var client = CreateMailClient("lists/"))
            {
                var response =
                    await
                        client.GetAsync(
                            $"{listId}/interest-categories/{interestCategoryId}/interests{request?.ToQueryString()}");
                await response.EnsureSuccessMailChimpAsync();

                var listResponse = await response.Content.ReadAsAsync<InterestResponse>();
                return listResponse.Interests;
            }
        }

        public async Task<Interest> GetAsync(string listId, string interestCategoryId, string interestId,
            BaseRequest request)
        {
            using (var client = CreateMailClient("lists/"))
            {
                var response =
                    await
                        client.GetAsync(
                            $"{listId}/interest-categories/{interestCategoryId}/interests/{interestId}{request?.ToQueryString()}");
                await response.EnsureSuccessMailChimpAsync();
                return await response.Content.ReadAsAsync<Interest>();
            }
        }

        public async Task DeleteAsync(string listId, string interestCategoryId, string interestId)
        {
            using (var client = CreateMailClient("lists/"))
            {
                var response =
                    await
                        client.DeleteAsync($"{listId}/interest-categories/{interestCategoryId}/interests/{interestId}");
                await response.EnsureSuccessMailChimpAsync();
            }
        }

        public async Task<Interest> UpdateAsync(Interest list)
        {
            using (var client = CreateMailClient("lists/"))
            {
                var response =
                    await
                        client.PatchAsJsonAsync(
                            $"{list.ListId}/interest-categories/{list.InterestCategoryId}/interests/{list.Id}", list);
                await response.EnsureSuccessMailChimpAsync();
                return await response.Content.ReadAsAsync<Interest>();
            }
        }
    }
}