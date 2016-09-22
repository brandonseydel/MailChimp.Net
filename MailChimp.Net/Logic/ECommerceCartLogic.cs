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
    internal class ECommerceCartLogic : BaseLogic, IECommerceCartLogic
    {
        /// <summary>
        /// The base url.
        /// </summary>
        private const string BaseUrl = "ecommerce/stores/{0}/carts";

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
        public async Task<Cart> AddAsync(Cart cart)
        {
            var requestUrl = string.Format(BaseUrl, this.StoreId);
            using (var client = CreateMailClient(requestUrl))
            {
                var response = await client.PostAsJsonAsync(string.Empty, cart).ConfigureAwait(false);
                await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

                var cartResponse = await response.Content.ReadAsAsync<Cart>().ConfigureAwait(false);
                return cartResponse;
            }
        }

        private static IECommerceLineLogic _cartLogic;

        public IECommerceLineLogic Lines(string cartId)
        {
            _cartLogic = _cartLogic ?? new ECommerceLineLogic(this._apiKey);
            _cartLogic.Resource = "carts";
            _cartLogic.ResourceId = cartId;
            _cartLogic.StoreId = this.StoreId;
            return _cartLogic;
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
        public async Task DeleteAsync(string cartId)
        {
            var requestUrl = string.Format(BaseUrl, StoreId);
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
        public async Task<IEnumerable<Cart>> GetAllAsync(QueryableBaseRequest request = null)
        {
            request = request ?? new QueryableBaseRequest
            {
                Limit = MailChimpManager.Limit
            };

            return (await GetResponseAsync(request).ConfigureAwait(false))?.Carts;
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
        public async Task<Cart> GetAsync(string cartId, BaseRequest request = null)
        {
            var requestUrl = string.Format(BaseUrl, StoreId);

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
        public async Task<CartResponse> GetResponseAsync(QueryableBaseRequest request = null)
        {
            var requestUrl = string.Format(BaseUrl, StoreId);
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
        public async Task<Cart> UpdateAsync(string cartId, Cart cart)
        {
            var requestUrl = string.Format(BaseUrl, StoreId);
            using (var client = CreateMailClient(requestUrl + "/"))
            {
                var response = await client.PatchAsJsonAsync(cartId, cart).ConfigureAwait(false);
                await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

                var cartResponse = await response.Content.ReadAsAsync<Cart>().ConfigureAwait(false);
                return cartResponse;
            }
        }

        public string StoreId { get; set; }
    }
}
