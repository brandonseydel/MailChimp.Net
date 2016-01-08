using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Interfaces;
using MailChimp.Net.Models;

namespace MailChimp.Net.Logic
{
    internal class ConversationLogic : BaseLogic, IConversationLogic
    {
        public ConversationLogic(string apiKey) : base(apiKey)
        {
        }

        public async Task<IEnumerable<Conversation>> GetAllAsync(ConversationRequest request = null)
        {
            using (var client = CreateMailClient("conversations"))
            {
                var response = await client.GetAsync(request?.ToQueryString());
                if (!response.IsSuccessStatusCode)
                {
                    throw (await response.Content.ReadAsStreamAsync()).Deserialize<MailChimpException>();
                }

                var conversationResponse = await response.Content.ReadAsAsync<ConversationResponse>();
                return conversationResponse.Conversations;
            }
        }
        
        public async Task<Conversation> GetAsync(string id)
        {
            using (var client = CreateMailClient("conversations/"))
            {
                var response = await client.GetAsync($"{id}");
                if (!response.IsSuccessStatusCode)
                {
                    throw (await response.Content.ReadAsStreamAsync()).Deserialize<MailChimpException>();
                }
                return await response.Content.ReadAsAsync<Conversation>();
            }
        }
    }
}