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
        public MemberLogic(string apiKey): base(apiKey){}
        
        public async Task<IEnumerable<Member>> GetAllAsync(string listId)
        {
            try
            {
                using (var client = CreateMailClient("lists/"))
                {
                    var response = await client.GetAsync($"{listId}/members");
                    response.EnsureSuccessStatusCode();

                    var listResponse = await response.Content.ReadAsAsync<MemberResponse>();
                    return listResponse.Members;
                }
            }
            catch (Exception ex)
            {
                
            }

            return null;
        }

        public async Task<Member> GetAsync(string listId, string emailAddress, bool isHashed = false)
        {
            try
            {
                using (var client = CreateMailClient("lists/"))
                {
                    var hashedEmailAddress = isHashed ? emailAddress : Hash(emailAddress);
                    var response = await client.GetAsync($"{listId}/members/{hashedEmailAddress}");
                    response.EnsureSuccessStatusCode();
                    return await response.Content.ReadAsAsync<Member>();
                }
            }
            catch (Exception ex)
            {

            }
            return null;
        }

        public async Task<Member> AddOrUpdateAsync(string listId, Member member, string targetEmailAddress = null)
        {
            try
            {
                // Reset the list-members to null that were initialized in the constructor and are actually empty, because the API doesn't like empty lists.
                if(member.Links != null && ((HashSet<Link>)member.Links).Count == 0)
                {
                    member.Links = null;
                }
                if(member.Interests != null && ((HashSet<Interest>)member.Interests).Count == 0)
                {
                    member.Interests = null;
                }
                if(member.MergeFields != null && member.MergeFields.Count == 0)
                {
                    member.MergeFields = null;
                }


                using (var client = CreateMailClient("lists/"))
                {
                    var hashedEmailAddress = string.IsNullOrWhiteSpace(targetEmailAddress)
                        ? Hash(member.EmailAddress)
                        : Hash(targetEmailAddress);
                    var response = await client.PutAsJsonAsync($"{listId}/members/{hashedEmailAddress}", member);
                    response.EnsureSuccessStatusCode();
                    return await response.Content.ReadAsAsync<Member>();
                }
            }
            catch (Exception ex)
            {

            }
            return null;
        }

    }
}
