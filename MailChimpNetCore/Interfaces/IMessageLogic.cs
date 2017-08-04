// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IMessageLogic.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Threading.Tasks;

using MailChimp.Net.Core;
using MailChimp.Net.Models;

namespace MailChimp.Net.Interfaces
{
    /// <summary>
    /// The MessageLogic interface.
    /// </summary>
    public interface IMessageLogic
    {
        /// <summary>
        /// The add async.
        /// </summary>
        /// <param name="conversationId">
        /// The conversation id.
        /// </param>
        /// <param name="member">
        /// The member.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<Message> AddAsync(string conversationId, Message member);

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
        Task<IEnumerable<Message>> GetAllAsync(string conversationId, MessageRequest request = null);

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
        Task<Message> GetAsync(string conversationId, string messageId);

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
        Task<MessageResponse> GetResponseAsync(string conversationId, MessageRequest request = null);
    }
}