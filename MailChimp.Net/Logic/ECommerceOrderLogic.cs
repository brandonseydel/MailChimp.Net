// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ECommerceOrderLogic.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Interfaces;
using MailChimp.Net.Models;

namespace MailChimp.Net.Logic
{
    internal class ECommerceOrderLogic : BaseLogic, IECommerceOrderLogic
    {
        /// <summary>
        /// The base url.
        /// </summary>
        private const string BaseUrl = "ecommerce/stores/{0}/orders";

        public ECommerceOrderLogic(MailChimpOptions mailChimpConfiguration)
            : base(mailChimpConfiguration)
        {
        }

        /// <summary>
        /// Adds a order to the given store by id
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public async Task<Order> AddAsync(Order order)
        {
            var requestUrl = string.Format(BaseUrl, StoreId);
            using (var client = CreateMailClient(requestUrl))
            {
                var response = await client.PostAsJsonAsync(string.Empty, order).ConfigureAwait(false);
                await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

                var orderResponse = await response.Content.ReadAsAsync<Order>().ConfigureAwait(false);
                return orderResponse;
            }
        }

        private static IECommerceLineLogic _orderLogic;

        public IECommerceLineLogic Lines(string orderId)
        {
            _orderLogic = _orderLogic ?? new ECommerceLineLogic(_options);
            _orderLogic.Resource = "orders";
            _orderLogic.ResourceId = orderId;
            _orderLogic.StoreId = StoreId;
            return _orderLogic;
        }

        /// <summary>
        /// Deletes an order
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        public async Task DeleteAsync(string orderId)
        {
            var requestUrl = string.Format(BaseUrl, StoreId);
            using (var client = CreateMailClient(requestUrl + "/"))
            {
                var response = await client.DeleteAsync(orderId).ConfigureAwait(false);
                await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
            }
        }

        /// <summary>
        /// Gets only the orders from the response object
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Order>> GetAllAsync(OrderRequest request = null)
        {
            return (await GetResponseAsync(request).ConfigureAwait(false))?.Orders;
        }

        /// <summary>
        /// The get async.
        /// </summary>
        /// <param name="orderId"></param>
        /// <param name="request">
        /// The request.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        public async Task<Order> GetAsync(string orderId, BaseRequest request = null)
        {
            var requestUrl = string.Format(BaseUrl, StoreId);

            using (var client = CreateMailClient(requestUrl + "/"))
            {
                var response = await client.GetAsync(orderId + request?.ToQueryString()).ConfigureAwait(false);
                await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

                var orderResponse = await response.Content.ReadAsAsync<Order>().ConfigureAwait(false);
                return orderResponse;
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
        public async Task<StoreOrderResponse> GetResponseAsync(OrderRequest request = null)
        {

            request = request ?? new OrderRequest
            {
                Limit = _limit
            };

            var requestUrl = string.Format(BaseUrl, StoreId);
            using (var client = CreateMailClient(requestUrl))
            {
                var response = await client.GetAsync(request.ToQueryString()).ConfigureAwait(false);
                await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

                var orderResponse = await response.Content.ReadAsAsync<StoreOrderResponse>().ConfigureAwait(false);
                return orderResponse;
            }
        }


        /// <summary>
        /// Updates an order
        /// </summary>
        /// <param name="orderId"></param>
        /// <param name="order"></param>
        /// <returns></returns>
        public async Task<Order> UpdateAsync(string orderId, Order order)
        {
            var requestUrl = string.Format(BaseUrl, StoreId);
            using (var client = CreateMailClient(requestUrl + "/"))
            {
                var response = await client.PatchAsJsonAsync(orderId, order).ConfigureAwait(false);
                await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

                var orderResponse = await response.Content.ReadAsAsync<Order>().ConfigureAwait(false);
                return orderResponse;
            }
        }

        public string StoreId { get; set; }
    }
}
