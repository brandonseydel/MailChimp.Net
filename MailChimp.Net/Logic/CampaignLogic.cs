using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Interfaces;
using MailChimp.Net.Models;
using MailChimp.Net.Requests;
using MailChimp.Net.Responses;

namespace MailChimp.Net.Logic
{
    internal class CampaignLogic : BaseLogic, ICampaignLogic
    {
        public CampaignLogic(string apiKey): base(apiKey){}
        
        public async Task<IEnumerable<Campaign>> GetAll(CampaignRequest request = null)
        {
            try
            {
                using (var client = CreateMailClient("campaigns"))
                {
                    var response = await client.GetAsync(request?.ToQueryString());
                    response.EnsureSuccessStatusCode();

                    var campaignResponse = await response.Content.ReadAsAsync<CampaignResponse>();
                    return campaignResponse.Campaigns;
                }
            }
            catch (Exception ex)
            {
                
            }

            return null;
        }

        public async Task<Campaign> GetAsync(string id)
        {
            using (var client = CreateMailClient("campaigns/"))
            {
                var response = await client.GetAsync($"{id}");
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsAsync<Campaign>();
            }
        }

        public async Task CancelAsync(string campaignId)
        {
            using (var client = CreateMailClient("campaigns/"))
            {
                var response = await client.PostAsync($"{campaignId}/actions/cancel-send", null);
                response.EnsureSuccessStatusCode();
            }
        }

        public async Task SendAsync(string campaignId)
        {
            using (var client = CreateMailClient("campaigns/"))
            {
                var response = await client.PostAsync($"{campaignId}/actions/send", null);
                response.EnsureSuccessStatusCode();
            }
        }

        public async Task DeleteAsync(string campaignId)
        {
            using (var client = CreateMailClient("campaigns/"))
            {
                var response = await client.DeleteAsync($"{campaignId}");
                response.EnsureSuccessStatusCode();
            }
        }

        public async Task<Campaign> AddOrUpdateAsync(string campaignId, Campaign campaign)
        {
            using (var client = CreateMailClient("campaigns/"))
            {
                var response = await client.PutAsJsonAsync($"{campaignId}", campaign);
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsAsync<Campaign>();
            }
        }

    }
}
