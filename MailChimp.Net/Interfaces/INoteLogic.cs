// --------------------------------------------------------------------------------------------------------------------
// <copyright file="INoteLogic.cs" company="Brandon Seydel">
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
    /// The NoteLogic interface.
    /// </summary>
    public interface INoteLogic
    {
        /// <summary>
        /// The add or update async.
        /// </summary>
        /// <param name="listId">
        /// The list id.
        /// </param>
        /// <param name="emailAddress">
        /// The email address.
        /// </param>
        /// <param name="noteId">
        /// The note id.
        /// </param>
        /// <param name="note">
        /// The note.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<Note> AddOrUpdateAsync(string listId, string emailAddress, string noteId, string note);

        /// <summary>
        /// The delete async.
        /// </summary>
        /// <param name="listId">
        /// The list id.
        /// </param>
        /// <param name="emailAddress">
        /// The email address.
        /// </param>
        /// <param name="noteId">
        /// The note id.
        /// </param>
        /// <param name="request">
        /// The request.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task DeleteAsync(string listId, string emailAddress, string noteId, BaseRequest request);

        /// <summary>
        /// The get all async.
        /// </summary>
        /// <param name="listId">
        /// The list id.
        /// </param>
        /// <param name="emailAddress">
        /// The email address.
        /// </param>
        /// <param name="request">
        /// The request.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<IEnumerable<Note>> GetAllAsync(string listId, string emailAddress, QueryableBaseRequest request = null);

        /// <summary>
        /// The get async.
        /// </summary>
        /// <param name="listId">
        /// The list id.
        /// </param>
        /// <param name="emailAddress">
        /// The email address.
        /// </param>
        /// <param name="noteId">
        /// The note id.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<Note> GetAsync(string listId, string emailAddress, string noteId);
    }
}