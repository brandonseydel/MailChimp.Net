// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NoteLogic.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Threading.Tasks;

using MailChimp.Net.Core;
using MailChimp.Net.Interfaces;
using MailChimp.Net.Models;
#pragma warning disable 1584,1711,1572,1581,1580

// ReSharper disable UnusedMember.Local
namespace MailChimp.Net.Logic
{
    /// <summary>
    /// The note logic.
    /// </summary>
    public class NoteLogic : BaseLogic, INoteLogic
    {

        public NoteLogic(IMailChimpConfiguration mailChimpConfiguration)
            : base(mailChimpConfiguration)
        {
        }

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
        public async Task<Note> AddOrUpdateAsync(string listId, string emailAddress, string noteId, string note)
        {
            using (var client = this.CreateMailClient("lists/"))
            {
                System.Net.Http.HttpResponseMessage response;
                if (string.IsNullOrWhiteSpace(noteId))
                {
                    response =
                        await
                        client.PostAsJsonAsync(
                            $"{listId}/members/{this.Hash(emailAddress.ToLower())}/notes", 
                            new { note }).ConfigureAwait(false);
                }
                else
                {
                    response =
                        await
                        client.PatchAsJsonAsync(
                            $"{listId}/members/{this.Hash(emailAddress.ToLower())}/notes/{noteId}", 
                            new { note }).ConfigureAwait(false);
                }

                await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

                return await response.Content.ReadAsAsync<Note>().ConfigureAwait(false);
            }
        }

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
        public async Task DeleteAsync(string listId, string emailAddress, string noteId, BaseRequest request = null)
        {
            using (var client = this.CreateMailClient("lists/"))
            {
                var response =
                    await
                    client.DeleteAsync(
                        $"{listId}/members/{this.Hash(emailAddress.ToLower())}/notes/{noteId}{request?.ToQueryString()}").ConfigureAwait(false);
                await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
            }
        }

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
        public async Task<IEnumerable<Note>> GetAllAsync(
            string listId,
            string emailAddress,
            QueryableBaseRequest request = null)
        {
            return (await GetResponseAsync(listId, emailAddress, request).ConfigureAwait(false))?.Notes;
        }

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
        public async Task<NoteResponse> GetResponseAsync(
            string listId,
            string emailAddress,
            QueryableBaseRequest request = null)
        {

            request = request ?? new QueryableBaseRequest
            {
                Limit = _limit
            };

            using (var client = this.CreateMailClient("lists/"))
            {
                var response =
                    await
                    client.GetAsync(
                        $"{listId}/members/{this.Hash(emailAddress.ToLower())}/notes{request.ToQueryString()}").ConfigureAwait(false);
                await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

                var noteResponse = await response.Content.ReadAsAsync<NoteResponse>().ConfigureAwait(false);
                return noteResponse;
            }
        }


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
        public async Task<Note> GetAsync(string listId, string emailAddress, string noteId)
        {
            using (var client = this.CreateMailClient("lists/"))
            {
                var response =
                    await client.GetAsync($"{listId}/members/{this.Hash(emailAddress.ToLower())}/notes{noteId}").ConfigureAwait(false);
                await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

                return await response.Content.ReadAsAsync<Note>().ConfigureAwait(false);
            }
        }
    }
}