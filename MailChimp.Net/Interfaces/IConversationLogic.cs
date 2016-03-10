// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IConversationLogic.cs" company="Brandon Seydel">
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
    /// The ConversationLogic interface.
    /// </summary>
    public interface IConversationLogic
    {
        /// <summary>
        /// The get all async.
        /// </summary>
        /// <param name="request">
        /// The request.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<IEnumerable<Conversation>> GetAllAsync(ConversationRequest request = null);

        /// <summary>
        /// The get async.
        /// </summary>
        /// <param name="conversationId">
        /// The conversation id.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<Conversation> GetAsync(string conversationId);
    }
}