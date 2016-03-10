// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IAuthorizedAppLogic.cs" company="Brandon Seydel">
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
    /// The AuthorizedAppLogic interface.
    /// </summary>
    public interface IAuthorizedAppLogic
    {
        /// <summary>
        /// The add async.
        /// </summary>
        /// <param name="clientId">
        /// The client id.
        /// </param>
        /// <param name="clientSecret">
        /// The client secret.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<AuthorizedAppCreatedResponse> AddAsync(string clientId, string clientSecret);

        /// <summary>
        /// The get all async.
        /// </summary>
        /// <param name="request">
        /// The request.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<IEnumerable<App>> GetAllAsync(AuthorizedAppRequest request = null);

        /// <summary>
        /// The get async.
        /// </summary>
        /// <param name="appId">
        /// The app id.
        /// </param>
        /// <param name="request">
        /// The request.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<App> GetAsync(string appId, BaseRequest request = null);
    }
}