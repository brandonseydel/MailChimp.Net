// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ICampaignFolderLogic.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace MailChimp.Net.Interfaces
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Core;
    using Models;

    /// <summary>
    /// The CampaignFolderLogic interface.
    /// </summary>
    public interface ICampaignFolderLogic
    {
        /// <summary>
        /// The add async.
        /// </summary>
        /// <param name="name">
        /// The name.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<Folder> AddAsync(string name);

        /// <summary>
        /// The get all async.
        /// </summary>
        /// <param name="request">
        /// The request.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<IEnumerable<Folder>> GetAllAsync(QueryableBaseRequest request = null);

        /// <summary>
        /// The get async.
        /// </summary>
        /// <param name="folderId">
        /// The folder id.
        /// </param>
        /// <param name="request">
        /// The request.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<Folder> GetAsync(string folderId, BaseRequest request = null);

        /// <summary>
        /// The delete async.
        /// </summary>
        /// <param name="folderId">
        /// The folder id.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task DeleteAsync(string folderId);

        /// <summary>
        /// The update async.
        /// </summary>
        /// <param name="folderId">
        /// The folder id.
        /// </param>
        /// <param name="name">
        /// The name.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<Folder> UpdateAsync(string folderId, string name);

        Task<CampaignFolderResponse> GetResponseAsync(QueryableBaseRequest request = null);
    }
}