using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Interfaces;
using MailChimp.Net.Models;

namespace MailChimp.Net.Logic
{
    internal class MessageLogic : BaseLogic, IMessageLogic
    {
        public MessageLogic(string apiKey) : base(apiKey)
        {
        }

        public async Task<IEnumerable<Message>> GetAllAsync(string conversationId, MessageRequest request = null)
        {
            using (var client = CreateMailClient($"conversations/{request?.ToQueryString()}"))
            {
                var response = await client.GetAsync($"{conversationId}/messages");
                await response.EnsureSuccessMailChimpAsync();


                var listResponse = await response.Content.ReadAsAsync<MessageResponse>();
                return listResponse.Messages;
            }
        }

        public async Task<Message> GetAsync(string conversationId, string messageId)
        {
            using (var client = CreateMailClient("conversations/"))
            {
                var response = await client.GetAsync($"{conversationId}/messages/{messageId}");
                await response.EnsureSuccessMailChimpAsync();

                return await response.Content.ReadAsAsync<Message>();
            }
        }

        public async Task<Message> AddAsync(string conversationId, Message message)
        {
            using (var client = CreateMailClient("conversations/"))
            {
                var response = await client.PutAsJsonAsync($"{conversationId}", message, null);
                await response.EnsureSuccessMailChimpAsync();

                return await response.Content.ReadAsAsync<Message>();
            }
        }
    }
}