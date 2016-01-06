using System;
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
        public MemberLogic(string apiKey) : base(apiKey) { }

        public async Task<IEnumerable<Member>> GetAllAsync(string listId)
        {
            using (var client = CreateMailClient("lists/"))
            {
                var response = await client.GetAsync($"{listId}/members");
                response.EnsureSuccessStatusCode();

                var listResponse = await response.Content.ReadAsAsync<MemberResponse>();
                return listResponse.Members;
            }
        }

        public async Task<Member> GetAsync(string listId, string emailAddress)
        {
            using (var client = CreateMailClient("lists/"))
            {
                var response = await client.GetAsync($"{listId}/members/{Hash(emailAddress)}");
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsAsync<Member>();
            }

        }

        public async Task<Member> AddOrUpdateAsync(string listId, Member member)
        {
            HttpResponseMessage response;   
            using (var client = CreateMailClient("lists/"))
            {
                response = await client.PutAsJsonAsync($"{listId}/members/{Hash(member.EmailAddress)}", member, null);
                response.EnsureSuccessStatusCode();                

                return await response.Content.ReadAsAsync<Member>();
            }

        }

    }
}
