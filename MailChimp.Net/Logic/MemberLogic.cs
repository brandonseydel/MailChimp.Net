using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Interfaces;
using MailChimp.Net.Models;

namespace MailChimp.Net.Logic
{
    internal class MemberLogic : BaseLogic, IMemberLogic
    {
        public MemberLogic(string apiKey) : base(apiKey)
        {
        }

        public async Task<IEnumerable<Member>> GetAllAsync(string listId)
        {
            using (var client = CreateMailClient("lists/"))
            {
                var response = await client.GetAsync($"{listId}/members");
                await response.EnsureSuccessMailChimpAsync();


                var listResponse = await response.Content.ReadAsAsync<MemberResponse>();
                return listResponse.Members;
            }
        }

        public async Task<Member> GetAsync(string listId, string emailAddress)
        {
            using (var client = CreateMailClient("lists/"))
            {
                var response = await client.GetAsync($"{listId}/members/{Hash(emailAddress.ToLower())}");
                await response.EnsureSuccessMailChimpAsync();

                return await response.Content.ReadAsAsync<Member>();
            }
        }

        public async Task<Member> AddOrUpdateAsync(string listId, Member member)
        {
            using (var client = CreateMailClient("lists/"))
            {
                var response =
                    await client.PutAsJsonAsync($"{listId}/members/{Hash(member.EmailAddress.ToLower())}", member, null);

                await response.EnsureSuccessMailChimpAsync();

                return await response.Content.ReadAsAsync<Member>();
            }
        }

        public async Task DeleteAsync(string listId, string emailAddress)
        {
            using (var client = CreateMailClient("lists/"))
            {
                var response = await client.DeleteAsync($"{listId}/members/{Hash(emailAddress.ToLower())}");
                await response.EnsureSuccessMailChimpAsync();
            }
        }

        public async Task<IEnumerable<Goal>> GetGoalsAsync(string listId, string emailAddress, BaseRequest request)
        {
            using (var client = CreateMailClient("lists/"))
            {
                var response = await client.GetAsync($"{listId}/members/{Hash(emailAddress.ToLower())}/goals{request.ToQueryString()}");
                await response.EnsureSuccessMailChimpAsync();
                var goalResponse = await response.Content.ReadAsAsync<GoalResponse>();
                return goalResponse.Goals;
            }
        }

        public async Task<IEnumerable<Activity>> GetActivitiesAsync(string listId, string emailAddress, BaseRequest request)
        {
            using (var client = CreateMailClient("lists/"))
            {
                var response = await client.GetAsync($"{listId}/members/{Hash(emailAddress.ToLower())}/activity{request.ToQueryString()}");
                await response.EnsureSuccessMailChimpAsync();
                var goalResponse = await response.Content.ReadAsAsync<ActivityResponse>();
                return goalResponse.Activities;
            }
        }

    }
}