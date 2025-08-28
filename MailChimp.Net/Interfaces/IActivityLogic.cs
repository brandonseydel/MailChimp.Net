// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IActivityLogic.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

using MailChimp.Net.Core;
using MailChimp.Net.Models;

namespace MailChimp.Net.Interfaces;

/// <summary>
/// The ActivityLogic interface.
/// </summary>
public interface IActivityLogic
{
    /// <summary>
    /// The get all async.
    /// </summary>
    /// <param name="listId">
    /// The list id.
    /// </param>
    /// <param name="request">
    /// The request.
    /// </param>
    /// <returns>
    /// The <see cref="Task"/>.
    /// </returns>
    Task<IEnumerable<Activity>> GetAllAsync(string listId, BaseRequest request = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// The get all async.
    /// </summary>
    /// <param name="listId">
    /// The list Id.
    /// </param>
    /// <param name="request">
    /// The request.
    /// </param>
    /// <exception cref="ArgumentNullException">
    /// The <paramref name="requestUri"/> was null.
    /// </exception>
    /// <returns>
    /// The <see cref="Task"/>.
    /// </returns>
    Task<ActivityResponse> GetResponseAsync(string listId, BaseRequest request = null, CancellationToken cancellationToken = default);


    /// <summary>
    /// Retrieves all the chimp chatter activity
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    Task<ChimpChatterResponse> GetChimpChatterResponseAsync(QueryableBaseRequest request = null, CancellationToken cancellationToken = default);

}