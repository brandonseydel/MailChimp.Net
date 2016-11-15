// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MessageLogic.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using static System.Net.Http.HttpContentExtensions;
using System.Threading.Tasks;

using MailChimp.Net.Core;
using MailChimp.Net.Interfaces;
using MailChimp.Net.Models;
#pragma warning disable 1584,1711,1572,1581,1580

// ReSharper disable UnusedMember.Local
namespace MailChimp.Net.Logic
{
    /// <summary>
    /// The message logic.
    /// </summary>
    internal class MessageLogic : BaseLogic, IMessageLogic
    {

        public MessageLogic(IMailChimpConfiguration mailChimpConfiguration)
            : base(mailChimpConfiguration)
        {
        }

        /// <summary>
        /// The add async.
        /// </summary>
        /// <param name="conversationId">
        /// The conversation id.
        /// </param>
        /// <param name="message">
        /// The message.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        public async Task<Message> AddAsync(string conversationId, Message message)
        {
            using (var client = this.CreateMailClient("conversations/"))
            {
                var response = await client.PutAsJsonAsync($"{conversationId}", message, null);
                await response.EnsureSuccessMailChimpAsync();

                return await response.Content.ReadAsAsync<Message>();
            }
        }

        /// <summary>
        /// The get all async.
        /// </summary>
        /// <param name="conversationId">
        /// The conversation id.
        /// </param>
        /// <param name="request">
        /// The request.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        public async Task<IEnumerable<Message>> GetAllAsync(string conversationId, MessageRequest request = null)
        {
            return (await GetResponseAsync(conversationId, request).ConfigureAwait(false))?.Messages;
        }

        /// <summary>
        /// The get all async.
        /// </summary>
        /// <param name="conversationId">
        /// The conversation id.
        /// </param>
        /// <param name="request">
        /// The request.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        public async Task<MessageResponse> GetResponseAsync(string conversationId, MessageRequest request = null)
        {
            
            using (var client = this.CreateMailClient($"conversations/{request?.ToQueryString()}"))
            {
                var response = await client.GetAsync($"{conversationId}/messages");
                await response.EnsureSuccessMailChimpAsync();

                var listResponse = await response.Content.ReadAsAsync<MessageResponse>();
                return listResponse;
            }
        }


        /// <summary>
        /// The get async.
        /// </summary>
        /// <param name="conversationId">
        /// The conversation id.
        /// </param>
        /// <param name="messageId">
        /// The message id.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        public async Task<Message> GetAsync(string conversationId, string messageId)
        {
            using (var client = this.CreateMailClient("conversations/"))
            {
                var response = await client.GetAsync($"{conversationId}/messages/{messageId}");
                await response.EnsureSuccessMailChimpAsync();

                return await response.Content.ReadAsAsync<Message>();
            }
        }
    }
}