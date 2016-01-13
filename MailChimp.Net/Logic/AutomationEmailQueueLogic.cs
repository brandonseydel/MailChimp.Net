using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Interfaces;
using MailChimp.Net.Models;

namespace MailChimp.Net.Logic
{
    internal class AutomationEmailQueueLogic : BaseLogic, IAutomationEmailQueueLogic
    {
        public AutomationEmailQueueLogic(string apiKey) : base(apiKey)
        {
        }

        public async Task<IEnumerable<Queue>> GetAllAsync(string workflowId, string workflowEmailId)
        {
            using (var client = CreateMailClient("automations/"))
            {
                var response = await client.GetAsync($"{workflowId}/emails/{workflowEmailId}/queue");
                await response.EnsureSuccessMailChimpAsync();
                var automationResponse = await response.Content.ReadAsAsync<AutomationEmailQueueResponse>();
                return automationResponse.Queues;
            }
        }

        public async Task<Queue> GetAsync(string workflowId, string workflowEmailId, string emailAddress)
        {
            using (var client = CreateMailClient("automations/"))
            {
                var response =
                    await client.GetAsync($"{workflowId}/emails/{workflowEmailId}/queue/{Hash(emailAddress.ToLower())}");
                await response.EnsureSuccessMailChimpAsync();
                return await response.Content.ReadAsAsync<Queue>();
            }
        }

        public async Task<Queue> AddSubscriberAsync(string workflowId, string workflowEmailId, string emailAddress)
        {
            using (var client = CreateMailClient("automations/"))
            {
                var response =
                    await
                        client.PostAsJsonAsync($"{workflowId}/emails/{workflowEmailId}/queue",
                            new {email_address = emailAddress});
                await response.EnsureSuccessMailChimpAsync();
                return await response.Content.ReadAsAsync<Queue>();
            }
        }
    }
}