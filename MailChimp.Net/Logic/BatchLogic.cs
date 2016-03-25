// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BatchOperationLogic.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Interfaces;

namespace MailChimp.Net.Logic
{
    /// <summary>
    /// The batch operation logic.
    /// </summary>
    internal class BatchLogic : BaseLogic, IBatchLogic
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Logic.BatchLogic"/> class.
        /// </summary>
        /// <param name="apiKey">
        /// The api key.
        /// </param>
        public BatchLogic(string apiKey) : base(apiKey)
        {
        }

        public async Task<Batch> AddAsync(BatchRequest request)
        {
            using (var client = this.CreateMailClient("batches"))
            {
                var response =
                    await
                        client.PostAsJsonAsync(string.Empty, request)
                            .ConfigureAwait(false);
                await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
                return await response.Content.ReadAsAsync<Batch>().ConfigureAwait(false);
            }
        }

        public async Task<IEnumerable<Batch>> GetAllAsync(QueryableBaseRequest request = null)
        {
            using (var client = this.CreateMailClient("batches"))
            {
                var response =
                    await
                        client.GetAsync(request?.ToQueryString() ?? string.Empty)
                            .ConfigureAwait(false);
                await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
                var batchResponse = await response.Content.ReadAsAsync<BatchResponse>().ConfigureAwait(false);
                return batchResponse.Batches;
            }
        }

        public async Task<BatchResponse> GetResponseAsync(QueryableBaseRequest request = null)
        {
            using (var client = this.CreateMailClient("batches"))
            {
                var response =
                    await
                        client.GetAsync(request?.ToQueryString() ?? string.Empty)
                            .ConfigureAwait(false);
                await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
                var batchResponse = await response.Content.ReadAsAsync<BatchResponse>().ConfigureAwait(false);
                return batchResponse;
            }
        }



    }
}