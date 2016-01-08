using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Interfaces;
using MailChimp.Net.Models;

namespace MailChimp.Net.Logic
{
    public class AutomationEmailLogic : BaseLogic, IAutomationEmailLogic
    {
        public AutomationEmailLogic(string apiKey) : base(apiKey)
        {
        }

        public async Task<IEnumerable<Email>> GetAllAsync(string workflowId)
        {
            using (var client = CreateMailClient("automations"))
            {
                var response = await client.GetAsync($"{workflowId}/emails");
                await response.EnsureSuccessMailChimpAsync();
                var automationResponse = await response.Content.ReadAsAsync<AutomationEmailResponse>();
                return automationResponse.Emails;
            }
        }

        public async Task<Email> GetAsync(string workflowId, string workflowEmailId)
        {
            using (var client = CreateMailClient("automations/"))
            {
                var response = await client.GetAsync($"{workflowId}/emails/{workflowEmailId}");
                await response.EnsureSuccessMailChimpAsync();
                return await response.Content.ReadAsAsync<Email>();
            }
        }

        public async Task PauseAsync(string workflowId, string workflowEmailId)
        {
            using (var client = CreateMailClient("automations/"))
            {
                
                var response = await client.PostAsync($"{workflowId}/emails/{workflowEmailId}/actions/pause", null);
                await response.EnsureSuccessMailChimpAsync();
            }
        }

        public async Task StartAsync(string workflowId, string workflowEmailId)
        {
            using (var client = CreateMailClient("automations/"))
            {
                var response = await client.PostAsync($"{workflowId}/emails/{workflowEmailId}/actions/start", null);
                await response.EnsureSuccessMailChimpAsync();
            }
        }
    }
    
}