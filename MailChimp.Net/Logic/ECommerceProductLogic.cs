// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ECommerceProductLogic.cs" company="Brandon Seydel">
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
    internal class ECommerceProductLogic : BaseLogic, IECommerceProductLogic
    {
        /// <summary>
        /// The base url.
        /// </summary>
        private const string BaseUrl = "ecommerce/stores/{0}/products";

        private static IECommerceProductVarianceLogic _productVarianceLogic;

        /// <summary>
        /// Initializes a new instance of the <see cref="ECommerceLogic"/> class.
        /// </summary>
        /// <param name="apiKey">
        /// The api key.
        /// </param>
        public ECommerceProductLogic(string apiKey)
            : base(apiKey)
        {
        }

        public IECommerceProductVarianceLogic Variants(string productId)
        {
            _productVarianceLogic = _productVarianceLogic ?? new ECommerceProductVarianceLogic(this._apiKey);
            _productVarianceLogic.StoreId = this.StoreId;
            _productVarianceLogic.ProductId = productId;
            return _productVarianceLogic;
        }


        /// <summary>
        /// Adds a product to the given store by id
        /// </summary>
        /// <param name="storeId"></param>
        /// <param name="product"></param>
        /// <returns></returns>
        public async Task<Product> AddAsync(Product product)
        {
            var requestUrl = string.Format(BaseUrl, this.StoreId);
            using (var client = CreateMailClient(requestUrl))
            {
                var response = await client.PostAsJsonAsync(string.Empty, product).ConfigureAwait(false);
                await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

                var productResponse = await response.Content.ReadAsAsync<Product>().ConfigureAwait(false);
                return productResponse;
            }
        }
        
        public async Task DeleteAsync(string productId)
        {
            var requestUrl = string.Format(BaseUrl, StoreId);
            using (var client = CreateMailClient(requestUrl + "/"))
            {
                var response = await client.DeleteAsync(productId).ConfigureAwait(false);
                await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
            }
        }

        /// <summary>
        /// Gets only the products from the response object
        /// </summary>
        /// <param name="storeId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Product>> GetAllAsync(QueryableBaseRequest request = null)
        {
            return (await GetResponseAsync(request).ConfigureAwait(false))?.Products;
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
        public async Task<Product> GetAsync(string productId, BaseRequest request = null)
        {
            var requestUrl = string.Format(BaseUrl, StoreId);

            using (var client = CreateMailClient(requestUrl + "/"))
            {
                var response = await client.GetAsync(productId + request?.ToQueryString()).ConfigureAwait(false);
                await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

                var productResponse = await response.Content.ReadAsAsync<Product>().ConfigureAwait(false);
                return productResponse;
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
        public async Task<StoreProductResponse> GetResponseAsync(QueryableBaseRequest request = null)
        {
            var requestUrl = string.Format(BaseUrl, StoreId);
            using (var client = CreateMailClient(requestUrl))
            {
                var response = await client.GetAsync(request?.ToQueryString()).ConfigureAwait(false);
                await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

                var productResponse = await response.Content.ReadAsAsync<StoreProductResponse>().ConfigureAwait(false);
                return productResponse;
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
        public async Task<Product> UpdateAsync(string productId, Product product)
        {
            var requestUrl = string.Format(BaseUrl, StoreId);
            using (var client = CreateMailClient(requestUrl + "/"))
            {
                var response = await client.PatchAsJsonAsync(productId, product).ConfigureAwait(false);
                await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

                var productResponse = await response.Content.ReadAsAsync<Product>().ConfigureAwait(false);
                return productResponse;
            }
        }

        public string StoreId { get; set; }
    }
}
