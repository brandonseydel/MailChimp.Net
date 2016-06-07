// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ECommerceCartLogic.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Interfaces;
using MailChimp.Net.Models;
using static System.Net.Http.HttpContentExtensions;

namespace MailChimp.Net.Logic
{
    public class ECommerceCartLogic : BaseLogic, IECommerceCartLogic
    {
        /// <summary>
        /// The base url.
        /// </summary>
        private const string BaseUrl = "ecommerce/stores/{0}/carts";

        /// <summary>
        /// Initializes a new instance of the <see cref="ECommerceLogic"/> class.
        /// </summary>
        /// <param name="apiKey">
        /// The api key.
        /// </param>
        public ECommerceCartLogic(string apiKey)
            : base(apiKey)
        {
        }

        /// <summary>
        /// Adds a cart to the given store by id
        /// </summary>
        /// <param name="storeId"></param>
        /// <param name="cart"></param>
        /// <returns></returns>
        public async Task<Cart> AddAsync(string storeId, Cart cart)
        {
            var requestUrl = string.Format(BaseUrl, storeId);
            using (var client = CreateMailClient(requestUrl))
            {
                var response = await client.PostAsJsonAsync(string.Empty, cart).ConfigureAwait(false);
                await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

                var cartResponse = await response.Content.ReadAsAsync<Cart>().ConfigureAwait(false);
                return cartResponse;
            }
        }

        /// <summary>
        /// The delete async.
        /// </summary>
        /// <param name="storeId">
        /// The store id.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        public async Task DeleteAsync(string storeId, string cartId)
        {
            var requestUrl = string.Format(BaseUrl, storeId);
            using (var client = CreateMailClient(requestUrl + "/"))
            {
                var response = await client.DeleteAsync(cartId).ConfigureAwait(false);
                await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
            }
        }

        /// <summary>
        /// Gets only the carts from the response object
        /// </summary>
        /// <param name="storeId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Cart>> GetAllAsync(string storeId, QueryableBaseRequest request = null)
        {
            return (await GetResponseAsync(storeId, request).ConfigureAwait(false))?.Carts;
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
        public async Task<Cart> GetAsync(string storeId, string cartId, BaseRequest request = null)
        {
            var requestUrl = string.Format(BaseUrl, storeId);

            using (var client = CreateMailClient(requestUrl + "/"))
            {
                var response = await client.GetAsync(cartId + request?.ToQueryString()).ConfigureAwait(false);
                await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

                var cartResponse = await response.Content.ReadAsAsync<Cart>().ConfigureAwait(false);
                return cartResponse;
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
        public async Task<CartResponse> GetResponseAsync(string storeId, QueryableBaseRequest request = null)
        {
            var requestUrl = string.Format(BaseUrl, storeId);
            using (var client = CreateMailClient(requestUrl))
            {
                var response = await client.GetAsync(request?.ToQueryString()).ConfigureAwait(false);
                await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

                var cartResponse = await response.Content.ReadAsAsync<CartResponse>().ConfigureAwait(false);
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
        public async Task<Cart> UpdateAsync(string storeId, string cartId, Cart cart)
        {
            var requestUrl = string.Format(BaseUrl, storeId);
            using (var client = CreateMailClient(requestUrl + "/"))
            {
                var response = await client.PatchAsJsonAsync(cartId, cart).ConfigureAwait(false);
                await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

                var cartResponse = await response.Content.ReadAsAsync<Cart>().ConfigureAwait(false);
                return cartResponse;
            }
        }
    }
}
