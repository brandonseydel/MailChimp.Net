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
        private readonly IListLogic _listLogic;
        private readonly IMemberLogic _memberLogic;

        public MailChimpManager(string apiKey) : base(apiKey)
        {
            _listLogic = new ListLogic(ApiKey);
            _memberLogic = new MemberLogic(ApiKey);
        }

        public MailChimpManager()
        {
            _listLogic = new ListLogic(ApiKey);
            _memberLogic = new MemberLogic(ApiKey);
        }

        public async Task<IEnumerable<List>> GetListsAsync()
        {
            return await _listLogic.GetAll();
        }

        public async Task<List> GetListAsync(string id)
        {
            return await _listLogic.GetAsync(id);
        }

        public async Task<IEnumerable<Member>> GetListMembersAsync(string listId)
        {
            
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
