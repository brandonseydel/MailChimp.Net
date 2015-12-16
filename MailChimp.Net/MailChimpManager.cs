using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Interfaces;
using MailChimp.Net.Logic;
using MailChimp.Net.Models;
using MailChimp.Net.Requests;

namespace MailChimp.Net
{
    public class MailChimpManager : MailManagerBase, IMailChimpManager
    {
        private readonly IListLogic _listLogic;
        private readonly IMemberLogic _memberLogic;
        private readonly IApiLogic _apiLogic;
        private readonly ICampaignLogic _campaignLogic;

        public MailChimpManager(string apiKey) : base(apiKey)
        {
            _listLogic = new ListLogic(ApiKey);
            _apiLogic = new ApiLogic(ApiKey);
            _memberLogic = new MemberLogic(ApiKey);
            _campaignLogic = new CampaignLogic(ApiKey);
        }

        public MailChimpManager()
        {
            _listLogic = new ListLogic(ApiKey);
            _memberLogic = new MemberLogic(ApiKey);
            _apiLogic = new ApiLogic(ApiKey);
        }

        public async Task<ApiInfo> GetApiInfoAsync()
        {
            return await _apiLogic.GetInfo();
        }

        public async Task<IEnumerable<Campaign>> GetCampaignsAsync(CampaignRequest request = null)
        {
            return await _campaignLogic.GetAll(request);
        }
        public async Task<Campaign> GetCampaignAsync(string campaignId)
        {
            return await _campaignLogic.GetAsync(campaignId);
        }

        public async Task<IEnumerable<List>> GetListsAsync(ListRequest request = null)
        {
            return await _listLogic.GetAll( request);
        }

        public async Task<List> GetListAsync(string id)
        {
            return await _listLogic.GetAsync(id);
        }

        public async Task<IEnumerable<Member>> GetListMembersAsync(string listId)
        {            
            return await _memberLogic.GetAllByListIdAsync(listId);
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
