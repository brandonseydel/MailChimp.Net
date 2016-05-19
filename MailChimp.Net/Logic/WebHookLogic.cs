// --------------------------------------------------------------------------------------------------------------------
// <copyright file="WebHookLogic.cs" company="Brandon Seydel">
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

namespace MailChimp.Net.Logic
{
    /// <summary>
    /// The web hook logic.
    /// </summary>
    public class WebHookLogic : BaseLogic, IWebHookLogic
    {
        /// <summary>
        /// The base url.
        /// </summary>
        private const string BaseUrl = "/lists/{0}/webhooks";

        /// <summary>
        /// Initializes a new instance of the <see cref="WebHookLogic"/> class.
        /// </summary>
        /// <param name="apiKey">
        /// The api key.
        /// </param>
        public WebHookLogic(string apiKey) : base(apiKey)
        {
        }

        /// <summary>
        /// The add async.
        /// </summary>
        /// <param name="listId">
        /// The list id.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        public async Task<WebHook> AddAsync(string listId)
        {
            using (var client = this.CreateMailClient(string.Format(BaseUrl, listId)))
            {
                var response = await client.PostAsync(string.Empty, null).ConfigureAwait(false);
                await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

                var webHookResponse = await response.Content.ReadAsAsync<WebHook>().ConfigureAwait(false);
                return webHookResponse;
            }
        }

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
        public async Task DeleteAsync(string listId, string webhookId)
        {
            using (var client = this.CreateMailClient(string.Format(BaseUrl + "/", listId)))
            {
                var response = await client.DeleteAsync(webhookId).ConfigureAwait(false);
                await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
            }
        }

        /// <summary>
        /// The get all async.
        /// </summary>
        /// <param name="listId">
        /// The list id.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        public async Task<IEnumerable<WebHook>> GetAllAsync(string listId)
        {
            return (await this.GetResponseAsync(listId))?.Webhooks;
        }

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
        public async Task<WebHook> GetAsync(string listId, string webhookId)
        {
            using (var client = this.CreateMailClient(string.Format(BaseUrl + "/", listId)))
            {
                var response = await client.GetAsync(webhookId).ConfigureAwait(false);
                await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

                var webHookResponse = await response.Content.ReadAsAsync<WebHook>().ConfigureAwait(false);
                return webHookResponse;
            }
        }

        /// <summary>
        /// The get response async.
        /// </summary>
        /// <param name="listId">
        /// The list id.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        public async Task<WebHookResponse> GetResponseAsync(string listId)
        {
            using (var client = this.CreateMailClient(string.Format(BaseUrl, listId)))
            {
                var response = await client.GetAsync(string.Empty).ConfigureAwait(false);
                await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

                var mergeResponse = await response.Content.ReadAsAsync<WebHookResponse>().ConfigureAwait(false);
                return mergeResponse;
            }
        }

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
        public async Task<MergeField> UpdateAsync(string listId, MergeField mergeField, int? mergeId = null)
        {
            using (var client = this.CreateMailClient(string.Format(BaseUrl + "/", listId)))
            {
                var response = await client.PatchAsJsonAsync((mergeId ?? mergeField.MergeId).ToString(), mergeField).ConfigureAwait(false);
                await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

                var mergeResponse = await response.Content.ReadAsAsync<MergeField>().ConfigureAwait(false);
                return mergeResponse;
            }
        }
    }
}
