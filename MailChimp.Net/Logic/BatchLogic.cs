// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BatchOperationLogic.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;
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
        public BatchLogic(MailchimpOptions mailChimpConfiguration)
            : base(mailChimpConfiguration)
        {
        }

        public async Task<Batch> AddAsync(BatchRequest request = null)
		{
			using (var client = CreateMailClient("batches"))
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
			return (await GetResponseAsync(request).ConfigureAwait(false))?.Batches;
		}

		public async Task<BatchResponse> GetResponseAsync(QueryableBaseRequest request = null)
		{
			request = request ?? new QueryableBaseRequest
			{
				Limit = _limit
			};

			using (var client = CreateMailClient("batches"))
			{
				var response =
					await
						client.GetAsync(request.ToQueryString() ?? string.Empty)
							.ConfigureAwait(false);
				await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
				var batchResponse = await response.Content.ReadAsAsync<BatchResponse>().ConfigureAwait(false);
				return batchResponse;
			}
		}

		public async Task DeleteAsync(string batchId)
		{
			using (var client = CreateMailClient("batches/"))
			{
				var response = await client.DeleteAsync($"{batchId}").ConfigureAwait(false);
				await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
			}
		}


		public async Task<Batch> GetBatchStatus(string batchId)
		{
			using (var client = CreateMailClient($"batches/{batchId}"))
			{
				var response =
					await
						client.GetAsync(string.Empty).ConfigureAwait(false);
				await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
				var batchStatus = await response.Content.ReadAsAsync<Batch>().ConfigureAwait(false);
				return batchStatus;	
			}
		}

	}
}