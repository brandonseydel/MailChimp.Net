// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BatchOperationLogic.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Net.Http;
using System.Threading.Tasks;
using ICSharpCode.SharpZipLib.Tar;
using MailChimp.Net.Core;
using MailChimp.Net.Interfaces;

namespace MailChimp.Net.Logic
{
	/// <summary>
	/// The batch operation logic.
	/// </summary>
	internal class BatchLogic : BaseLogic, IBatchLogic
	{
        public BatchLogic(IMailChimpConfiguration mailChimpConfiguration)
            : base(mailChimpConfiguration)
        {
        }

        public async Task<Batch> AddAsync(BatchRequest request = null)
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
			return (await this.GetResponseAsync(request).ConfigureAwait(false))?.Batches;
		}

		public async Task<BatchResponse> GetResponseAsync(QueryableBaseRequest request = null)
		{
			request = request ?? new QueryableBaseRequest
			{
				Limit = _limit
			};

			using (var client = this.CreateMailClient("batches"))
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
			using (var client = this.CreateMailClient("batches/"))
			{
				var response = await client.DeleteAsync($"{batchId}").ConfigureAwait(false);
				await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
			}
		}


		public async Task<Batch> GetBatchStatus(string batchId)
		{
			using (var client = this.CreateMailClient($"batches/{batchId}"))
			{
				var response =
					await
						client.GetAsync(string.Empty).ConfigureAwait(false);
				await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
				var batchStatus = await response.Content.ReadAsAsync<Batch>().ConfigureAwait(false);
				return batchStatus;	
			}
		}
		 public async Task<IEnumerable<OperationResponse>> GetOperationResponsesAsync(string batchId)
        {
            var batchInfo = await GetBatchStatus(batchId).ConfigureAwait(false);
            if (!batchInfo.Status.Equals("finished")) return new List<OperationResponse>();

            using (var client = new HttpClient())
            using (var request = new HttpRequestMessage())
            using (var memoryStream = new MemoryStream())
            {
                request.Method = HttpMethod.Get;
                request.RequestUri = new Uri(batchInfo.ResponseBodyUrl);

                var response = await client.SendAsync(request);

                var responseContentStream = await response.Content.ReadAsStreamAsync();

                using (var tarInputStream = new TarInputStream(new GZipStream(responseContentStream, CompressionMode.Decompress)))
                {
                    var tarEntry = tarInputStream.GetNextEntry();
                    while (tarEntry != null)
                    {
                        if (!tarEntry.IsDirectory && tarEntry.Name.Contains(".json"))
                        {
                            tarInputStream.CopyEntryContents(memoryStream);
                            memoryStream.Position = 0;
                            break;
                        }
                        tarEntry = tarInputStream.GetNextEntry();
                    }

                    var operationResponses = memoryStream.Deserialize<IEnumerable<OperationResponse>>();
                    return operationResponses;
                }
            }
        }

	}
}