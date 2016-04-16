// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IBatchOperationLogic.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MailChimp.Net.Core;

namespace MailChimp.Net.Interfaces
{
    /// <summary>
    /// The BatchOperationLogic interface.
    /// </summary>
    public interface IBatchLogic
    {
        Task<Batch> AddAsync(BatchRequest request = null);

        Task<IEnumerable<Batch>> GetAllAsync(QueryableBaseRequest request = null);

        Task<BatchResponse> GetResponseAsync(QueryableBaseRequest request = null);
    }
}