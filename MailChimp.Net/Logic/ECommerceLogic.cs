// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ECommerceLogic.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Interfaces;
using MailChimp.Net.Models;

namespace MailChimp.Net.Logic;

/// <summary>
/// The e commerce logic.
/// </summary>
public class ECommerceLogic : BaseLogic, IECommerceLogic
{
    /// <summary>
    /// The base url.
    /// </summary>
    private readonly string BaseUrl = "ecommerce/stores";

    public ECommerceLogic(MailChimpOptions mailChimpConfiguration)
        : base(mailChimpConfiguration)
    {
    }

    public IECommerceCartLogic Carts(string storeId) => new ECommerceCartLogic(_options)
    {
        StoreId = storeId
    };

    public IECommerceCustomerLogic Customers(string storeId) => new ECommerceCustomerLogic(_options)
    {
        StoreId = storeId
    };

    public IECommerceProductLogic Products(string storeId) => new ECommerceProductLogic(_options)
    {
        StoreId = storeId
    };

    public IECommerceOrderLogic Orders(string storeId) => new ECommerceOrderLogic(_options)
    {
        StoreId = storeId
    };

    public IECommercePromoRuleLogic PromoRules(string storeId) => new ECommercePromoRuleLogic(_options)
    {
        StoreId = storeId
    };

    /// <summary>
    /// The add async.
    /// </summary>
    /// <param name="store">
    /// The store.
    /// </param>
    /// <returns>
    /// The <see cref="Task"/>.
    /// </returns>
    public async Task<Store> AddAsync(Store store, CancellationToken cancellationToken = default)
    {
        using var client = CreateMailClient(BaseUrl);
        var response = await client.PostAsJsonAsync(string.Empty, store, cancellationToken).ConfigureAwait(false);
        await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

        var storeResponse = await response.Content.ReadAsAsync<Store>().ConfigureAwait(false);
        return storeResponse;
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
    public async Task DeleteAsync(string storeId, CancellationToken cancellationToken = default)
    {
        using var client = CreateMailClient(BaseUrl + "/");
        var response = await client.DeleteAsync(storeId, cancellationToken).ConfigureAwait(false);
        await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
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
    public async Task<IEnumerable<Store>> GetAllAsync(QueryableBaseRequest request = null, CancellationToken cancellationToken = default) => (await GetResponseAsync(request).ConfigureAwait(false))?.Stores;

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
    public async Task<Store> GetAsync(string storeId, BaseRequest request = null, CancellationToken cancellationToken = default)
    {
        using var client = CreateMailClient(BaseUrl + "/");
        var response = await client.GetAsync(storeId + request?.ToQueryString(), cancellationToken).ConfigureAwait(false);
        await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

        var storeResponse = await response.Content.ReadAsAsync<Store>().ConfigureAwait(false);
        return storeResponse;
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
    public async Task<ECommerceResponse> GetResponseAsync(QueryableBaseRequest request = null, CancellationToken cancellationToken = default)
    {
        request ??= new QueryableBaseRequest
        {
            Limit = _limit
        };

        using var client = CreateMailClient(BaseUrl);
        var response = await client.GetAsync(request.ToQueryString(), cancellationToken).ConfigureAwait(false);
        await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

        var storeResponse = await response.Content.ReadAsAsync<ECommerceResponse>().ConfigureAwait(false);
        return storeResponse;
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
    public async Task<Store> UpdateAsync(string storeId, Store store, CancellationToken cancellationToken = default)
    {
        using var client = CreateMailClient(BaseUrl + "/");
        var response = await client.PatchAsJsonAsync(storeId, store, cancellationToken).ConfigureAwait(false);
        await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

        var storeResponse = await response.Content.ReadAsAsync<Store>().ConfigureAwait(false);
        return storeResponse;
    }
}