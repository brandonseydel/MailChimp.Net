using System.Collections.Generic;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Interfaces;
using MailChimp.Net.Models;

namespace MailChimp.Net.Logic
{
    internal class ECommerceLineLogic : BaseLogic, IECommerceLineLogic
    {
        public string BaseUrl => $"ecommerce/stores/{StoreId}/{Resource}/{ResourceId}/lines";

        public ECommerceLineLogic(MailChimpOptions mailChimpConfiguration)
            : base(mailChimpConfiguration)
        {
        }

        public async Task<Line> AddAsync(Line line)
        {
            using var client = CreateMailClient(BaseUrl);
            var response = await client.PostAsJsonAsync(string.Empty, line).ConfigureAwait(false);
            await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

            var cartResponse = await response.Content.ReadAsAsync<Line>().ConfigureAwait(false);
            return cartResponse;
        }
        
        public async Task DeleteAsync(string lineId)
        {
            using var client = CreateMailClient(BaseUrl + "/");
            var response = await client.DeleteAsync(lineId).ConfigureAwait(false);
            await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
        }

        /// <summary>
        /// Gets only the carts from the response object
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Line>> GetAllAsync(QueryableBaseRequest request = null)
        {
            return (await GetResponseAsync(request).ConfigureAwait(false))?.Lines;
        }

        /// <summary>
        /// The get async.
        /// </summary>
        /// <param name="lineId"></param>
        /// <param name="request">
        /// The request.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        public async Task<Line> GetAsync(string lineId, BaseRequest request = null)
        {

            using var client = CreateMailClient(BaseUrl + "/");
            var response = await client.GetAsync(lineId + request?.ToQueryString()).ConfigureAwait(false);
            await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

            var lineResponse = await response.Content.ReadAsAsync<Line>().ConfigureAwait(false);
            return lineResponse;
        }

        /// <summary>
        /// The get response async.
        /// </summary>
        /// <param name="request">
        /// The request.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        public async Task<CartLineResponse> GetResponseAsync(QueryableBaseRequest request = null)
        {

            request ??= new QueryableBaseRequest
            {
                Limit = _limit
            };

            using var client = CreateMailClient(BaseUrl);
            var response = await client.GetAsync(request.ToQueryString()).ConfigureAwait(false);
            await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

            var cartResponse = await response.Content.ReadAsAsync<CartLineResponse>().ConfigureAwait(false);
            return cartResponse;
        }

        /// <summary>
        /// The update async.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        public async Task<Line> UpdateAsync(string lineId, Line line)
        {
            using var client = CreateMailClient(BaseUrl + "/");
            var response = await client.PatchAsJsonAsync(lineId, line).ConfigureAwait(false);
            await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

            var cartResponse = await response.Content.ReadAsAsync<Line>().ConfigureAwait(false);
            return cartResponse;
        }

        public string Resource { get; set; }
        public string ResourceId { get; set; }
        public string StoreId { get; set; }
    }
}
