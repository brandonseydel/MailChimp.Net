// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IMemberLogic.cs" company="Brandon Seydel">
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
    /// The MemberLogic interface.
    /// </summary>
    public interface IMemberLogic
    {
        /// <summary>
        /// The add or update async.
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
        Task<Member> AddOrUpdateAsync(string listId, Member member);

        /// <summary>
        /// The delete async.
        /// </summary>
        /// <param name="listId">
        /// The list id.
        /// </param>
        /// <param name="emailAddress">
        /// The email address.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task DeleteAsync(string listId, string emailAddress);

        /// <summary>
        /// The get all async.
        /// </summary>
        /// <param name="listId">
        /// The list id.
        /// </param>
        /// <param name="memberRequest"></param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<IEnumerable<Member>> GetAllAsync(string listId, MemberRequest memberRequest = null);

        /// <summary>
        /// The get async.
        /// </summary>
        /// <param name="listId">
        /// The list id.
        /// </param>
        /// <param name="emailAddress">
        /// The email address.
        /// </param>
        /// <param name="request"></param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<Member> GetAsync(string listId, string emailAddress, BaseRequest request = null);
    }
}