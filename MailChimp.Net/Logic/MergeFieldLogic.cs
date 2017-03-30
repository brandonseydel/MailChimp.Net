// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MergeFieldLogic.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;
using static System.Net.Http.HttpContentExtensions;
using System.Threading.Tasks;

using MailChimp.Net.Core;
using MailChimp.Net.Interfaces;
using MailChimp.Net.Models;

namespace MailChimp.Net.Logic
{
    /// <summary>
    /// The merge field logic.
    /// </summary>
    public class MergeFieldLogic : BaseLogic, IMergeFieldLogic
    {
        /// <summary>
        /// The base url.
        /// </summary>
        private const string BaseUrl = "/lists/{0}/merge-fields";


        public MergeFieldLogic(IMailChimpConfiguration mailChimpConfiguration)
            : base(mailChimpConfiguration)
        {
        }

        /// <summary>
        /// The add async.
        /// </summary>
        /// <param name="listId">
        /// The list id.
        /// </param>
        /// <param name="member">
        /// The member.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        public async Task<MergeField> AddAsync(string listId, MergeField member)
        {
            using (var client = this.CreateMailClient(string.Format(BaseUrl, listId)))
            {
                var response = await client.PostAsJsonAsync(string.Empty, member).ConfigureAwait(false);
                await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

                var mergeResponse = await response.Content.ReadAsAsync<MergeField>().ConfigureAwait(false);
                return mergeResponse;
            }
        }

        /// <summary>
        /// The delete async.
        /// </summary>
        /// <param name="listId">
        /// The list id.
        /// </param>
        /// <param name="mergeId">
        /// The merge id.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        public async Task DeleteAsync(string listId, int mergeId)
        {
            using (var client = this.CreateMailClient(string.Format(BaseUrl + "/", listId)))
            {
                var response = await client.DeleteAsync(mergeId.ToString()).ConfigureAwait(false);
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
        public async Task<IEnumerable<MergeField>> GetAllAsync(string listId, MergeFieldRequest request = null)
        {
            return (await GetResponseAsync(listId, request).ConfigureAwait(false))?.MergeFields;
        }

        /// <summary>
        /// The get async.
        /// </summary>
        /// <param name="listId">
        /// The list id.
        /// </param>
        /// <param name="mergeId">
        /// The merge id.
        /// </param>
        /// <param name="request"></param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        public async Task<MergeField> GetAsync(string listId, int mergeId, MergeFieldRequest request = null)
        {
            using (var client = this.CreateMailClient(string.Format(BaseUrl + "/", listId)))
            {
                var response = await client.GetAsync(mergeId + request?.ToQueryString()).ConfigureAwait(false);
                await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

                var mergeResponse = await response.Content.ReadAsAsync<MergeField>().ConfigureAwait(false);
                return mergeResponse;
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
        public async Task<MergeFieldResponse> GetResponseAsync(string listId, MergeFieldRequest request = null)
        {
            request = request ?? new MergeFieldRequest
            {
                Limit = base._limit
            };

            using (var client = this.CreateMailClient(string.Format(BaseUrl, listId)))
            {
                var response = await client.GetAsync(request?.ToQueryString()).ConfigureAwait(false);
                await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

                var mergeResponse = await response.Content.ReadAsAsync<MergeFieldResponse>().ConfigureAwait(false);
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