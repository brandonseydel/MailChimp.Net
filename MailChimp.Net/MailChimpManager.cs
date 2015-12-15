using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MailChimp.Net.Interfaces;
using MailChimp.Net.Logic;
using MailChimp.Net.Models;

namespace MailChimp.Net
{
    public class MailChimpManager : MailManagerBase, IMailChimpManager
    {
        public MailChimpManager(string apiKey) : base(apiKey) { }
        
        public MailChimpManager() { }

        public async Task<IEnumerable<List>> GetListsAsync()
        {
            var list = new ListLogic(ApiKey);
            return await list.GetAll();
        }

        public async Task<List> GetListAsync(string id)
        {
            var list = new ListLogic(ApiKey);
            return await list.GetAsync(id);
        }

        public async Task<IEnumerable<Member>> GetListMembersAsync(string listId)
        {
            var memberLogic = new MemberLogic(ApiKey);
            return await memberLogic.GetAllByListIdAsync(listId);
        }
        public async Task<Member> GetListMemberAsync(string listId, string emailAddress)
        {
            var memberLogic = new MemberLogic(ApiKey);
            return await memberLogic.GetListMemberAsync(listId, emailAddress);
        }

        public async Task<Member> AddOrUpdateListMemberAsync(string listId, Member member)
        {
            var memberLogic = new MemberLogic(ApiKey);
            return await memberLogic.AddOrUpdateMemberAsync(listId, member);
        }

    }
}
