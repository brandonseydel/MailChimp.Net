using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Interfaces;
using MailChimp.Net.Models;

namespace MailChimp.Net.Logic
{
    public class AutomationLogic : BaseLogic, IAutomationLogic
    {
        public AutomationLogic(string apiKey) : base(apiKey)
        {
        }

        public async Task<IEnumerable<Automation>> GetAllAsync(BaseRequest request = null)
        {
            using (var client = CreateMailClient("automations"))
            {
                var response = await client.GetAsync(request?.ToQueryString());
                await response.EnsureSuccessMailChimpAsync();
                var automationResponse = await response.Content.ReadAsAsync<AutomationResponse>();
                return automationResponse.Automations;
            }
        }

        public async Task<Automation> GetAsync(string workflowId)
        {
            using (var client = CreateMailClient("automations/"))
            {
                var response = await client.GetAsync(workflowId);
                await response.EnsureSuccessMailChimpAsync();
                return await response.Content.ReadAsAsync<Automation>();
            }
        }

        public async Task PauseAsync(string workflowId)
        {
            using (var client = CreateMailClient("automations/"))
            {
                var response = await client.GetAsync($"{workflowId}/actions/pause-all-emails");
                await response.EnsureSuccessMailChimpAsync();
            }
        }

        public async Task StartAsync(string workflowId)
        {
            using (var client = CreateMailClient("automations/"))
            {
                var response = await client.GetAsync($"{workflowId}/actions/start-all-emails");
                await response.EnsureSuccessMailChimpAsync();
            }
        }
    }
}