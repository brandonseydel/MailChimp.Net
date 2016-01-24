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
    public class InterestCategoryLogic : BaseLogic, IInterestCategoryLogic
    {
        public InterestCategoryLogic(string apiKey) : base(apiKey)
        {
        }

        public async Task<IEnumerable<InterestCategory>> GetAllAsync(string listId, InterestCategoryRequest request = null)
        {
            using (var client = CreateMailClient("lists/"))
            {
                var response = await client.GetAsync($"{listId}{request?.ToQueryString()}");
                await response.EnsureSuccessMailChimpAsync();


                var listResponse = await response.Content.ReadAsAsync<InterestCategoryResponse>();
                return listResponse.Categories;
            }
        }

        public async Task<List> GetAsync(string id)
        {
            using (var client = CreateMailClient("lists/"))
            {
                var response = await client.GetAsync($"{id}");
                await response.EnsureSuccessMailChimpAsync();

                return await response.Content.ReadAsAsync<List>();
            }
        }

        public async Task DeleteAsync(string listId)
        {
            using (var client = CreateMailClient("lists/"))
            {
                var response = await client.DeleteAsync(listId);
                await response.EnsureSuccessMailChimpAsync();
            }
        }

        public async Task<List> AddOrUpdateAsync(List list)
        {

            using (var client = CreateMailClient("lists/"))
            {
                HttpResponseMessage response;
                if (string.IsNullOrWhiteSpace(list.Id))
                {
                    response = await client.PostAsJsonAsync("", list);
                }
                else
                {
                    response = await client.PatchAsJsonAsync(list.Id, list);
                }

                await response.EnsureSuccessMailChimpAsync();

                return await response.Content.ReadAsAsync<List>();
            }
        }

    }
}
