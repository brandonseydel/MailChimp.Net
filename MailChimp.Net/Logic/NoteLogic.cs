using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Models;

namespace MailChimp.Net.Logic
{
    public class NoteLogic : BaseLogic
    {
        public NoteLogic(string apiKey) : base(apiKey)
        {
        }

        public async Task<IEnumerable<Note>> GetAllAsync(string listId, string emailAddress,
            QueryableBaseRequest request = null)
        {
            using (var client = CreateMailClient("lists"))
            {
                var response =
                    await
                        client.GetAsync(
                            $"{listId}/members/{Hash(emailAddress.ToLower())}/notes{request?.ToQueryString()}");
                await response.EnsureSuccessMailChimpAsync();

                var noteResponse = await response.Content.ReadAsAsync<NoteResponse>();
                return noteResponse.Notes;
            }
        }

        public async Task<Note> GetAsync(string listId, string emailAddress, string noteId)
        {
            using (var client = CreateMailClient("lists/"))
            {
                var response = await client.GetAsync($"{listId}/members/{Hash(emailAddress.ToLower())}/notes{noteId}");
                await response.EnsureSuccessMailChimpAsync();

                return await response.Content.ReadAsAsync<Note>();
            }
        }

        public async Task DeleteAsync(string listId, string emailAddress, string noteId, BaseRequest request)
        {
            using (var client = CreateMailClient("lists/"))
            {
                var response =
                    await
                        client.DeleteAsync(
                            $"{listId}/members/{Hash(emailAddress.ToLower())}/notes/{noteId}{request.ToQueryString()}");
                await response.EnsureSuccessMailChimpAsync();
            }
        }

        public async Task<Note> AddOrUpdateAsync(string listId, string emailAddress, string noteId, string note)
        {
            using (var client = CreateMailClient("lists/"))
            {
                HttpResponseMessage response;
                if (string.IsNullOrWhiteSpace(noteId))
                {
                    response =
                        await
                            client.PostAsJsonAsync($"{listId}/members/{Hash(emailAddress.ToLower())}/notes", new {note});
                }
                else
                {
                    response =
                        await
                            client.PatchAsJsonAsync($"{listId}/members/{Hash(emailAddress.ToLower())}/notes/{noteId}",
                                new {note});
                }

                await response.EnsureSuccessMailChimpAsync();

                return await response.Content.ReadAsAsync<Note>();
            }
        }
    }
}