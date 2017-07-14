using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Interfaces;
using MailChimp.Net.Models;

namespace MailChimp.Net.Logic
{
    public class BatchWebHookLogic : BaseLogic, IBatchWebHookLogic
    {

        private const string BaseUrl = "batch-webhooks";

        public BatchWebHookLogic(IMailChimpConfiguration mailChimpConfiguration) : base(mailChimpConfiguration)
        {
        }

        public async Task DeleteAsync(string batchWebHookId)
        {
            using (var client = this.CreateMailClient($"{BaseUrl}/"))
            {
                var response = await client.DeleteAsync(batchWebHookId).ConfigureAwait(false);
            }
        }

        public async Task<BatchWebHook> UpdateAsync(string batchWebHookId, string url)
        {
            using (var client = this.CreateMailClient($"{BaseUrl}/"))
            {
                var response = await client.PatchAsJsonAsync(batchWebHookId, new { url }).ConfigureAwait(false);
                await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
                return await response.Content.ReadAsAsync<BatchWebHook>().ConfigureAwait(false);
            }
        }

        public async Task<BatchWebHook> AddAsync(string url)
        {
            using (var client = this.CreateMailClient($"{BaseUrl}"))
            {
                var response = await client.PostAsJsonAsync("", new { url }).ConfigureAwait(false);
                await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
                return await response.Content.ReadAsAsync<BatchWebHook>().ConfigureAwait(false);
            }
        }

        public async Task<BatchWebHookResponse> GetResponseAsync(QueryableBaseRequest request = null)
        {
            request = request ?? new MemberRequest
            {
                Limit = _limit
            };

            using (var client = this.CreateMailClient($"{BaseUrl}"))
            {
                var response = await client.GetAsync($"{request.ToQueryString()}").ConfigureAwait(false);
                await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

                var batchWebHookResponse = await response.Content.ReadAsAsync<BatchWebHookResponse>().ConfigureAwait(false);
                return batchWebHookResponse;
            }
        }

        public async Task<IEnumerable<BatchWebHook>> GetAllAsync(QueryableBaseRequest request = null)
        {
            return (await this.GetResponseAsync(request).ConfigureAwait(false))?.WebHooks;

        }
    }
}
