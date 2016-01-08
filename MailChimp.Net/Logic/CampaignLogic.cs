using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Interfaces;
using MailChimp.Net.Models;

namespace MailChimp.Net.Logic
{
    internal class CampaignLogic : BaseLogic, ICampaignLogic
    {
        public CampaignLogic(string apiKey) : base(apiKey)
        {
        }

        public async Task<IEnumerable<Campaign>> GetAll(CampaignRequest request = null)
        {
            using (var client = CreateMailClient("campaigns"))
            {
                var response = await client.GetAsync(request?.ToQueryString());
                if (!response.IsSuccessStatusCode)
                {
                    throw (await response.Content.ReadAsStreamAsync()).Deserialize<MailChimpException>();
                }

                var campaignResponse = await response.Content.ReadAsAsync<CampaignResponse>();
                return campaignResponse.Campaigns;
            }
        }

        public async Task<SendChecklistResponse> SendChecklistAsync(string id)
        {
            using (var client = CreateMailClient("campaigns/"))
            {
                var response = await client.GetAsync($"{id}/send-checklist");
                await response.EnsureSuccessMailChimpAsync();
                return await response.Content.ReadAsAsync<SendChecklistResponse>();
            }
        }

        public async Task<Campaign> GetAsync(string id)
        {
            using (var client = CreateMailClient("campaigns/"))
            {
                var response = await client.GetAsync($"{id}");
                if (!response.IsSuccessStatusCode)
                {
                    throw (await response.Content.ReadAsStreamAsync()).Deserialize<MailChimpException>();
                }
                return await response.Content.ReadAsAsync<Campaign>();
            }
        }

        public async Task CancelAsync(string campaignId)
        {
            using (var client = CreateMailClient("campaigns/"))
            {
                var response = await client.PostAsync($"{campaignId}/actions/cancel-send", null);
                if (!response.IsSuccessStatusCode)
                {
                    throw (await response.Content.ReadAsStreamAsync()).Deserialize<MailChimpException>();
                }
            }
        }

        public async Task SendAsync(string campaignId)
        {
            using (var client = CreateMailClient("campaigns/"))
            {
                var response = await client.PostAsync($"{campaignId}/actions/send", null);
                if (!response.IsSuccessStatusCode)
                {
                    throw (await response.Content.ReadAsStreamAsync()).Deserialize<MailChimpException>();
                }
            }
        }

        public async Task DeleteAsync(string campaignId)
        {
            using (var client = CreateMailClient("campaigns/"))
            {
                var response = await client.DeleteAsync($"{campaignId}");
                if (!response.IsSuccessStatusCode)
                {
                    throw (await response.Content.ReadAsStreamAsync()).Deserialize<MailChimpException>();
                }
            }
        }

        public async Task<Campaign> AddOrUpdateAsync(string campaignId, Campaign campaign)
        {
            using (var client = CreateMailClient("campaigns/"))
            {
                var response = await client.PutAsJsonAsync($"{campaignId}", campaign, null);
                if (!response.IsSuccessStatusCode)
                {
                    throw (await response.Content.ReadAsStreamAsync()).Deserialize<MailChimpException>();
                }
                return await response.Content.ReadAsAsync<Campaign>();
            }
        }
    }
}