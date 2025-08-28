// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IBatchOperationLogic.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MailChimp.Net.Core;

namespace MailChimp.Net.Interfaces;

	/// <summary>
	/// The BatchOperationLogic interface.
	/// </summary>
	public interface IBatchLogic
	{
		Task<Batch> AddAsync(BatchRequest request = null, CancellationToken cancellationToken = default);

		Task<IEnumerable<Batch>> GetAllAsync(QueryableBaseRequest request = null, CancellationToken cancellationToken = default);

		Task<BatchResponse> GetResponseAsync(QueryableBaseRequest request = null, CancellationToken cancellationToken = default);

		Task<Batch> GetBatchStatus(string batchId, CancellationToken cancellationToken = default);

	    Task DeleteAsync(string batchId, CancellationToken cancellationToken = default);

	}