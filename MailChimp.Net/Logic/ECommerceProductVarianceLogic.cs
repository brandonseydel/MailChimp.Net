using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Interfaces;
using MailChimp.Net.Models;
using static System.Net.Http.HttpContentExtensions;

namespace MailChimp.Net.Logic
{
    internal class ECommerceProductVarianceLogic : BaseLogic, IECommerceProductVarianceLogic
    {
        public string BaseUrl => $"ecommerce/stores/{this.StoreId}/products/{this.ProductId}/variants";

        public string ProductId { get; set; }

        internal ECommerceProductVarianceLogic(string apiKey) : base(apiKey)
        {
            _limit = MailChimpConfiguration.DefaultLimit;
        }

        public ECommerceProductVarianceLogic(string apiKey, int limit) : base(apiKey, limit)
        {
        }

        public async Task<Variant> AddAsync(Variant variant)
        {
            using (var client = CreateMailClient(this.BaseUrl))
            {
                var response = await client.PostAsJsonAsync(string.Empty, variant).ConfigureAwait(false);
                await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

                var variantResponse = await response.Content.ReadAsAsync<Variant>().ConfigureAwait(false);
                return variantResponse;
            }
        }

        public async Task DeleteAsync(string variantId)
        {
            using (var client = CreateMailClient(BaseUrl + "/"))
            {
                var response = await client.DeleteAsync(variantId).ConfigureAwait(false);
                await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
            }
        }

        /// <summary>
        /// Gets only the carts from the response object
        /// </summary>
        /// <param name="storeId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Variant>> GetAllAsync(QueryableBaseRequest request = null)
        {
            return (await GetResponseAsync(request).ConfigureAwait(false))?.Variants;
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
        public async Task<Variant> GetAsync(string variantId, BaseRequest request = null)
        {

            using (var client = CreateMailClient(BaseUrl + "/"))
            {
                var response = await client.GetAsync(variantId + request?.ToQueryString()).ConfigureAwait(false);
                await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

                var variantResponse = await response.Content.ReadAsAsync<Variant>().ConfigureAwait(false);
                return variantResponse;
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
        public async Task<ProductVariantResponse> GetResponseAsync(QueryableBaseRequest request = null)
        {

            request = new QueryableBaseRequest
            {
                Limit = base._limit
            };

            using (var client = CreateMailClient(BaseUrl))
            {
                var response = await client.GetAsync(request?.ToQueryString()).ConfigureAwait(false);
                await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

                var variantResponse = await response.Content.ReadAsAsync<ProductVariantResponse>().ConfigureAwait(false);
                return variantResponse;
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
        public async Task<Variant> UpdateAsync(string variantId, Variant variant)
        {
            using (var client = CreateMailClient(BaseUrl + "/"))
            {
                var response = await client.PatchAsJsonAsync(variantId, variant).ConfigureAwait(false);
                await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

                var variantResponse = await response.Content.ReadAsAsync<Variant>().ConfigureAwait(false);
                return variantResponse;
            }
        }
        public string StoreId { get; set; }
    }
}
