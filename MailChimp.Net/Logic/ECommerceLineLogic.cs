using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Interfaces;
using MailChimp.Net.Models;
using static System.Net.Http.HttpContentExtensions;

namespace MailChimp.Net.Logic
{
    internal class ECommerceLineLogic : BaseLogic, IECommerceLineLogic
    {
        public string BaseUrl
        {
            get { return $"ecommerce/stores/{this.StoreId}/{this.Resource}/{this.ResourceId}/lines"; }
        }

        internal ECommerceLineLogic(string apiKey) : base(apiKey)
        {
        }


        public async Task<Line> AddAsync(Line line)
        {
            using (var client = CreateMailClient(this.BaseUrl))
            {
                var response = await client.PostAsJsonAsync(string.Empty, line).ConfigureAwait(false);
                await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

                var cartResponse = await response.Content.ReadAsAsync<Line>().ConfigureAwait(false);
                return cartResponse;
            }
        }
        
        public async Task DeleteAsync(string lineId)
        {
            using (var client = CreateMailClient(BaseUrl + "/"))
            {
                var response = await client.DeleteAsync(lineId).ConfigureAwait(false);
                await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
            }
        }

        /// <summary>
        /// Gets only the carts from the response object
        /// </summary>
        /// <param name="storeId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Line>> GetAllAsync(QueryableBaseRequest request = null)
        {
            return (await GetResponseAsync(request).ConfigureAwait(false))?.Lines;
        }

        /// <summary>
        /// The get async.
        /// </summary>
        /// <param name="storeId">
        /// The store id.
        /// </param>
        /// <param name="request">
        /// The request.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        public async Task<Line> GetAsync(string lineId, BaseRequest request = null)
        {

            using (var client = CreateMailClient(BaseUrl + "/"))
            {
                var response = await client.GetAsync(lineId + request?.ToQueryString()).ConfigureAwait(false);
                await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

                var lineResponse = await response.Content.ReadAsAsync<Line>().ConfigureAwait(false);
                return lineResponse;
            }
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
            using (var client = CreateMailClient(BaseUrl))
            {
                var response = await client.GetAsync(request?.ToQueryString()).ConfigureAwait(false);
                await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

                var cartResponse = await response.Content.ReadAsAsync<CartLineResponse>().ConfigureAwait(false);
                return cartResponse;
            }
        }

        /// <summary>
        /// The update async.
        /// </summary>
        /// <param name="storeId">
        /// The store id.
        /// </param>
        /// <param name="store">
        /// The store.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        public async Task<Line> UpdateAsync(string lineId, Line line)
        {
            using (var client = CreateMailClient(BaseUrl + "/"))
            {
                var response = await client.PatchAsJsonAsync(lineId, line).ConfigureAwait(false);
                await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

                var cartResponse = await response.Content.ReadAsAsync<Line>().ConfigureAwait(false);
                return cartResponse;
            }
        }

        public string Resource { get; set; }
        public string ResourceId { get; set; }
        public string StoreId { get; set; }
    }
}
