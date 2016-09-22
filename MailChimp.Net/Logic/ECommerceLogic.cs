// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ECommerceLogic.cs" company="Brandon Seydel">
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

namespace MailChimp.Net.Logic
{
    /// <summary>
    /// The e commerce logic.
    /// </summary>
    public class ECommerceLogic : BaseLogic, IECommerceLogic
    {
        /// <summary>
        /// The base url.
        /// </summary>
        private string BaseUrl = "ecommerce/stores";

        private static IECommerceCartLogic _carts;
        private static IECommerceCustomerLogic _customers;
        private static IECommerceOrderLogic _orders;
        private static IECommerceProductLogic _products;

        /// <summary>
        /// Initializes a new instance of the <see cref="ECommerceLogic"/> class.
        /// </summary>
        /// <param name="apiKey">
        /// The api key.
        /// </param>
        public ECommerceLogic(string apiKey)
            : base(apiKey)
        {
        }


        public IECommerceCartLogic Carts(string storeId)
        {
            _carts = _carts ?? new ECommerceCartLogic(this._apiKey);
            _carts.StoreId = storeId;
            return _carts;
        }

        public IECommerceCustomerLogic Customers(string storeId)
        {
            _customers = _customers ?? new ECommerceCustomerLogic(this._apiKey);
            _customers.StoreId = storeId;
            return _customers;
        }

        public IECommerceProductLogic Products(string storeId)
        {
            _products = _products ?? new ECommerceProductLogic(this._apiKey);
            _products.StoreId = storeId;
            return _products;
        }

        public IECommerceOrderLogic Orders(string storeId)
        {
            _orders = _orders ?? new ECommerceOrderLogic(this._apiKey);
            _orders.StoreId = storeId;
            return _orders;
        }

        /// <summary>
        /// The add async.
        /// </summary>
        /// <param name="store">
        /// The store.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        public async Task<Store> AddAsync(Store store)
        {
            using (var client = this.CreateMailClient(BaseUrl))
            {
                var response = await client.PostAsJsonAsync(string.Empty, store).ConfigureAwait(false);
                await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

                var storeResponse = await response.Content.ReadAsAsync<Store>().ConfigureAwait(false);
                return storeResponse;
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
        public async Task DeleteAsync(string storeId)
        {
            using (var client = this.CreateMailClient(BaseUrl + "/"))
            {
                var response = await client.DeleteAsync(storeId).ConfigureAwait(false);
                await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
            }
        }

        /// <summary>
        /// The get all async.
        /// </summary>
        /// <param name="request">
        /// The request.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        public async Task<IEnumerable<Store>> GetAllAsync(QueryableBaseRequest request = null)
        {
            request = request ?? new QueryableBaseRequest
            {
                Limit = MailChimpManager.Limit
            };

            return (await this.GetResponseAsync(request).ConfigureAwait(false))?.Stores;
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
        public async Task<Store> GetAsync(string storeId, BaseRequest request = null)
        {
            using (var client = this.CreateMailClient(BaseUrl + "/"))
            {
                var response = await client.GetAsync(storeId + request?.ToQueryString()).ConfigureAwait(false);
                await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

                var storeResponse = await response.Content.ReadAsAsync<Store>().ConfigureAwait(false);
                return storeResponse;
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
        public async Task<ECommerceResponse> GetResponseAsync(QueryableBaseRequest request = null)
        {
            using (var client = this.CreateMailClient(BaseUrl))
            {
                var response = await client.GetAsync(request?.ToQueryString()).ConfigureAwait(false);
                await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

                var storeResponse = await response.Content.ReadAsAsync<ECommerceResponse>().ConfigureAwait(false);
                return storeResponse;
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
        public async Task<Store> UpdateAsync(string storeId, Store store)
        {
            using (var client = this.CreateMailClient(BaseUrl + "/"))
            {
                var response = await client.PatchAsJsonAsync(storeId, store).ConfigureAwait(false);
                await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

                var storeResponse = await response.Content.ReadAsAsync<Store>().ConfigureAwait(false);
                return storeResponse;
            }
        }
    }
}