// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IInterestLogic.cs" company="Brandon Seydel">
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
    /// The InterestLogic interface.
    /// </summary>
    public interface IInterestLogic
    {
        /// <summary>
        /// The delete async.
        /// </summary>
        /// <param name="listId">
        /// The list id.
        /// </param>
        /// <param name="interestCategoryId">
        /// The interest category id.
        /// </param>
        /// <param name="interestId">
        /// The interest id.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task DeleteAsync(string listId, string interestCategoryId, string interestId);

        /// <summary>
        /// The get all async.
        /// </summary>
        /// <param name="listId">
        /// The list id.
        /// </param>
        /// <param name="interestCategoryId">
        /// The interest category id.
        /// </param>
        /// <param name="request">
        /// The request.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<IEnumerable<Interest>> GetAllAsync(string listId, string interestCategoryId, QueryableBaseRequest request);

        /// <summary>
        /// The get async.
        /// </summary>
        /// <param name="listId">
        /// The list id.
        /// </param>
        /// <param name="interestCategoryId">
        /// The interest category id.
        /// </param>
        /// <param name="interestId">
        /// The interest id.
        /// </param>
        /// <param name="request">
        /// The request.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<Interest> GetAsync(string listId, string interestCategoryId, string interestId, BaseRequest request);

        /// <summary>
        /// The update async.
        /// </summary>
        /// <param name="list">
        /// The list.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<Interest> UpdateAsync(Interest list);
    }
}