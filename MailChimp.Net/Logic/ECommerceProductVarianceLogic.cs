using System.Collections.Generic;
using System.Threading;
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

        public async Task<Variant> AddAsync(Variant variant, CancellationToken cancellationToken = default)
        {
            using var client = CreateMailClient(BaseUrl);
            var response = await client.PostAsJsonAsync(string.Empty, variant, cancellationToken).ConfigureAwait(false);
            await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

            var variantResponse = await response.Content.ReadAsAsync<Variant>().ConfigureAwait(false);
            return variantResponse;
        }

        public async Task DeleteAsync(string variantId, CancellationToken cancellationToken = default)
        {
            using var client = CreateMailClient(BaseUrl + "/");
            var response = await client.DeleteAsync(variantId, cancellationToken).ConfigureAwait(false);
            await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
        }

        /// <summary>
        /// Gets only the carts from the response object
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Variant>> GetAllAsync(QueryableBaseRequest request = null, CancellationToken cancellationToken = default) 
            => (await GetResponseAsync(request, cancellationToken).ConfigureAwait(false))?.Variants;

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
        public async Task<Variant> GetAsync(string variantId, BaseRequest request = null, CancellationToken cancellationToken = default)
        {

            using var client = CreateMailClient(BaseUrl + "/");
            var response = await client.GetAsync(variantId + request?.ToQueryString(), cancellationToken).ConfigureAwait(false);
            await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

            var variantResponse = await response.Content.ReadAsAsync<Variant>().ConfigureAwait(false);
            return variantResponse;
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
        public async Task<ProductVariantResponse> GetResponseAsync(QueryableBaseRequest request = null, CancellationToken cancellationToken = default)
        {

            request ??= new QueryableBaseRequest
            {
                Limit = _limit
            };

            using var client = CreateMailClient(BaseUrl);
            var response = await client.GetAsync(request.ToQueryString(), cancellationToken).ConfigureAwait(false);
            await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

            var variantResponse = await response.Content.ReadAsAsync<ProductVariantResponse>().ConfigureAwait(false);
            return variantResponse;
        }

        /// <summary>
        /// The update async.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        public async Task<Variant> UpdateAsync(string variantId, Variant variant, CancellationToken cancellationToken = default)
        {
            using var client = CreateMailClient(BaseUrl + "/");
            var response = await client.PatchAsJsonAsync(variantId, variant, cancellationToken).ConfigureAwait(false);
            await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

            var variantResponse = await response.Content.ReadAsAsync<Variant>().ConfigureAwait(false);
            return variantResponse;
        }
        public string StoreId { get; set; }
    }
}
