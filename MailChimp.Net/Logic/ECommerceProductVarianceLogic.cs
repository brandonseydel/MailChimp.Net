using System.Collections.Generic;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Interfaces;
using MailChimp.Net.Models;

namespace MailChimp.Net.Logic
{
    internal class ECommerceProductVarianceLogic : BaseLogic, IECommerceProductVarianceLogic
    {
        public string BaseUrl => $"ecommerce/stores/{StoreId}/products/{ProductId}/variants";

        public string ProductId { get; set; }

        public ECommerceProductVarianceLogic(MailChimpOptions mailChimpConfiguration)
            : base(mailChimpConfiguration)
        {
        }

        public async Task<Variant> AddAsync(Variant variant)
        {
            using (var client = CreateMailClient(BaseUrl))
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
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Variant>> GetAllAsync(QueryableBaseRequest request = null)
        {
            return (await GetResponseAsync(request).ConfigureAwait(false))?.Variants;
        }

        /// <summary>
        /// The get async.
        /// </summary>
        /// <param name="variantId"></param>
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

            request = request ?? new QueryableBaseRequest
            {
                Limit = _limit
            };

            using (var client = CreateMailClient(BaseUrl))
            {
                var response = await client.GetAsync(request.ToQueryString()).ConfigureAwait(false);
                await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

                var variantResponse = await response.Content.ReadAsAsync<ProductVariantResponse>().ConfigureAwait(false);
                return variantResponse;
            }
        }

        /// <summary>
        /// The update async.
        /// </summary>
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
