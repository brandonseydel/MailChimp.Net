// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IWebHookLogic.cs" company="Brandon Seydel">
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
    /// The WebHookLogic interface.
    /// </summary>
    public interface IWebHookLogic
    {
        /// <summary>
        /// The add async.
        /// </summary>
        /// <param name="listId">
        /// The list id.
        /// </param>
        /// <param name="webhook">
        /// Webhook.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<WebHook> AddAsync(string listId, WebHook webhook);

        /// <summary>
        /// The delete async.
        /// </summary>
        /// <param name="listId">
        /// The list id.
        /// </param>
        /// <param name="webhookId">
        /// The webhook id.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task DeleteAsync(string listId, string webhookId);

        /// <summary>
        /// The get all async.
        /// </summary>
        /// <param name="listId">
        /// The list id.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<IEnumerable<WebHook>> GetAllAsync(string listId);

        /// <summary>
        /// The get async.
        /// </summary>
        /// <param name="listId">
        /// The list id.
        /// </param>
        /// <param name="webhookId">
        /// The webhook id.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<WebHook> GetAsync(string listId, string webhookId);

        /// <summary>
        /// The get response async.
        /// </summary>
        /// <param name="listId">
        /// The list id.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<WebHookResponse> GetResponseAsync(string listId);

        /// <summary>
        /// The update async.
        /// </summary>
        /// <param name="listId">
        /// The list id.
        /// </param>
        /// <param name="mergeField">
        /// The merge field.
        /// </param>
        /// <param name="mergeId">
        /// The merge id.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<WebHook> UpdateAsync(string listId, WebHook mergeField, string? Id = null);
    }
}
