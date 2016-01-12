using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Interfaces;
using MailChimp.Net.Models;

namespace MailChimp.Net.Logic
{
    public class AutomationSubscriberLogic : BaseLogic, IAutomationSubscriberLogic
    {
        public AutomationSubscriberLogic(string apiKey) : base(apiKey)
        {
        }

        public async Task<IEnumerable<Subscriber>> GetRemovedSubscribersAsync(string workflowId)
        {
            using (var client = CreateMailClient("automations/"))
            {
                var response = await client.GetAsync($"{workflowId}/removed-subscribers");
                await response.EnsureSuccessMailChimpAsync();
                var automationResponse = await response.Content.ReadAsAsync<AutomationSubscriberResponse>();
                return automationResponse.Subscribers;
            }
        }

        public async Task<Subscriber> RemoveSubscriberAsync(string workflowId, string emailAddress)
        {
            using (var client = CreateMailClient("automations/"))
            {
                var response =
                    await
                        client.PostAsJsonAsync($"{workflowId}/removed-subscribers", new {email_address = emailAddress});
                await response.EnsureSuccessMailChimpAsync();
                return await response.Content.ReadAsAsync<Subscriber>();
            }
        }
    }
}