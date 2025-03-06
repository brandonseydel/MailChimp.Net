// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ECommerceCustomerLogic.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Interfaces;
using MailChimp.Net.Models;

namespace MailChimp.Net.Logic
{
    internal class ECommercePromoRuleLogic : BaseLogic, IECommercePromoRuleLogic
    {
        /// <summary>
        /// The base url.
        /// </summary>
        private const string BaseUrl = "ecommerce/stores/{0}/promo-rules";


        public ECommercePromoRuleLogic(MailChimpOptions mailChimpConfiguration)
            : base(mailChimpConfiguration)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        public async Task<PromoRule> AddAsync(PromoRule customer, CancellationToken cancellationToken = default)
        {
            var requestUrl = string.Format(BaseUrl, StoreId);
            using var client = CreateMailClient(requestUrl);
            var response = await client.PostAsJsonAsync(string.Empty, customer, cancellationToken).ConfigureAwait(false);
            await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

            var promoRuleResponse = await response.Content.ReadAsAsync<PromoRule>().ConfigureAwait(false);
            return promoRuleResponse;
        }

        /// <summary>
        /// The delete async.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        public async Task DeleteAsync(string promoRuleID, CancellationToken cancellationToken = default)
        {
            var requestUrl = string.Format(BaseUrl, StoreId);
            using var client = CreateMailClient(requestUrl + "/");
            var response = await client.DeleteAsync(promoRuleID, cancellationToken).ConfigureAwait(false);
            await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
        }

        /// <summary>
        /// Gets only the customers from the response object
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<IEnumerable<PromoRule>> GetAllAsync(QueryableBaseRequest request = null, CancellationToken cancellationToken = default) 
            => (await GetResponseAsync(request, cancellationToken).ConfigureAwait(false))?.PromoRules;

        /// <summary>
        /// The get async.
        /// </summary>
        /// <param name="customerId"></param>
        /// <param name="request">
        /// The request.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        public async Task<PromoRule> GetAsync(string customerId, BaseRequest request = null, CancellationToken cancellationToken = default)
        {
            var requestUrl = string.Format(BaseUrl, StoreId);

            using var client = CreateMailClient(requestUrl + "/");
            var response = await client.GetAsync(customerId + request?.ToQueryString(), cancellationToken).ConfigureAwait(false);
            await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

            var promoRuleResponse = await response.Content.ReadAsAsync<PromoRule>().ConfigureAwait(false);
            return promoRuleResponse;
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
        public async Task<StorePromoRuleResponse> GetResponseAsync(QueryableBaseRequest request = null, CancellationToken cancellationToken = default)
        {

            request ??= new QueryableBaseRequest
            {
                Limit = _limit
            };

            var requestUrl = string.Format(BaseUrl, StoreId);
            using var client = CreateMailClient(requestUrl);
            var response = await client.GetAsync(request.ToQueryString(), cancellationToken).ConfigureAwait(false);
            await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

            var promoResponse = await response.Content.ReadAsAsync<StorePromoRuleResponse>().ConfigureAwait(false);
            return promoResponse;
        }

        /// <summary>
        /// The update async.
        /// </summary>
        /// <param name="cartId"></param>
        /// <param name="cart"></param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        public async Task<PromoRule> UpdateAsync(string promoRuleID, PromoRule promoRule, CancellationToken cancellationToken = default)
        {
            var requestUrl = string.Format(BaseUrl, StoreId);
            using var client = CreateMailClient(requestUrl + "/");
            var response = await client.PatchAsJsonAsync(promoRuleID, promoRule, cancellationToken).ConfigureAwait(false);
            await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

            var promoRuleResponse = await response.Content.ReadAsAsync<PromoRule>().ConfigureAwait(false);
            return promoRuleResponse;
        }


        public IEcommercePromoCodeLogic Codes(string promoRuleID) => new ECommercePromoCodeLogic(_options)
        {
            Resource = "promo-rules",
            ResourceId = promoRuleID,
            StoreId = StoreId
        };
        public string StoreId { get; set; }
    }
}
