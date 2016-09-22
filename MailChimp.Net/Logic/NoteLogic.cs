// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NoteLogic.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using static System.Net.Http.HttpContentExtensions;
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
        /// <summary>
        /// Initializes a new instance of the <see cref="NoteLogic"/> class.
        /// </summary>
        /// <param name="apiKey">
        /// The api key.
        /// </param>
        public NoteLogic(string apiKey)
            : base(apiKey)
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
                            new { note });
                }
                else
                {
                    response =
                        await
                        client.PatchAsJsonAsync(
                            $"{listId}/members/{this.Hash(emailAddress.ToLower())}/notes/{noteId}", 
                            new { note });
                }

                await response.EnsureSuccessMailChimpAsync();

                return await response.Content.ReadAsAsync<Note>();
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
                        $"{listId}/members/{this.Hash(emailAddress.ToLower())}/notes/{noteId}{request?.ToQueryString()}");
                await response.EnsureSuccessMailChimpAsync();
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
            request = request ?? new QueryableBaseRequest
            {
                Limit = MailChimpManager.Limit
            };

            using (var client = this.CreateMailClient("lists/"))
            {
                var response =
                    await
                    client.GetAsync(
                        $"{listId}/members/{this.Hash(emailAddress.ToLower())}/notes{request?.ToQueryString()}");
                await response.EnsureSuccessMailChimpAsync();

                var noteResponse = await response.Content.ReadAsAsync<NoteResponse>();
                return noteResponse.Notes;
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
        public async Task<NoteResponse> GetResponseAsync(
            string listId,
            string emailAddress,
            QueryableBaseRequest request = null)
        {
            using (var client = this.CreateMailClient("lists/"))
            {
                var response =
                    await
                    client.GetAsync(
                        $"{listId}/members/{this.Hash(emailAddress.ToLower())}/notes{request?.ToQueryString()}");
                await response.EnsureSuccessMailChimpAsync();

                var noteResponse = await response.Content.ReadAsAsync<NoteResponse>();
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
                    await client.GetAsync($"{listId}/members/{this.Hash(emailAddress.ToLower())}/notes{noteId}");
                await response.EnsureSuccessMailChimpAsync();

                return await response.Content.ReadAsAsync<Note>();
            }
        }
    }
}