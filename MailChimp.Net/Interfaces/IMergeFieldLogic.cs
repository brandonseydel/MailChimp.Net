// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IMergeFieldLogic.cs" company="Brandon Seydel">
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
/// The MergeFieldLogic interface.
/// </summary>
public interface IMergeFieldLogic
{
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
    Task<MergeField> AddAsync(string listId, MergeField member, CancellationToken cancellationToken = default);

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
    Task DeleteAsync(string listId, int mergeId, CancellationToken cancellationToken = default);

    /// <summary>
    /// The get all async.
    /// </summary>
    /// <param name="listId">
    /// The list id.
    /// </param>
    /// <param name="request"></param>
    /// <returns>
    /// The <see cref="Task"/>.
    /// </returns>
    Task<IEnumerable<MergeField>> GetAllAsync(string listId, MergeFieldRequest request = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// The get all async.
    /// </summary>
    /// <param name="listId">
    /// The list id.
    /// </param>
    /// <param name="request"></param>
    /// <returns>
    /// The <see cref="Task"/>.
    /// </returns>
    Task<MergeFieldResponse> GetResponseAsync(string listId, MergeFieldRequest request = null, CancellationToken cancellationToken = default);


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
    Task<MergeField> GetAsync(string listId, int mergeId, MergeFieldRequest request = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// The update async.
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
    Task<MergeField> UpdateAsync(string listId, MergeField mergeField, int? mergeId = null, CancellationToken cancellationToken = default);
}