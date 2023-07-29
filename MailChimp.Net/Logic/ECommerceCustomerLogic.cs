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

namespace MailChimp.Net.Logic;

internal class ECommerceCustomerLogic : BaseLogic, IECommerceCustomerLogic
{
    /// <summary>
    /// The base url.
    /// </summary>
    private const string BaseUrl = "ecommerce/stores/{0}/customers";


    public ECommerceCustomerLogic(MailChimpOptions mailChimpConfiguration)
        : base(mailChimpConfiguration)
    {
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="customer"></param>
    /// <returns></returns>
    public async Task<Customer> AddAsync(Customer customer, CancellationToken cancellationToken = default)
    {
        var requestUrl = string.Format(BaseUrl, StoreId);
        using var client = CreateMailClient(requestUrl);
        var response = await client.PostAsJsonAsync(string.Empty, customer, cancellationToken).ConfigureAwait(false);
        await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

        var customerResponse = await response.Content.ReadAsAsync<Customer>().ConfigureAwait(false);
        return customerResponse;
    }

    /// <summary>
    /// The delete async.
    /// </summary>
    /// <returns>
    /// The <see cref="Task"/>.
    /// </returns>
    public async Task DeleteAsync(string customerId, CancellationToken cancellationToken = default)
    {
        var requestUrl = string.Format(BaseUrl, StoreId);
        using var client = CreateMailClient(requestUrl + "/");
        var response = await client.DeleteAsync(customerId, cancellationToken).ConfigureAwait(false);
        await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
    }

    /// <summary>
    /// Gets only the customers from the response object
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    public async Task<IEnumerable<Customer>> GetAllAsync(QueryableBaseRequest request = null, CancellationToken cancellationToken = default) 
        => (await GetResponseAsync(request, cancellationToken).ConfigureAwait(false))?.Customers;

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
    public async Task<Customer> GetAsync(string customerId, BaseRequest request = null, CancellationToken cancellationToken = default)
    {
        var requestUrl = string.Format(BaseUrl, StoreId);

        using var client = CreateMailClient(requestUrl + "/");
        var response = await client.GetAsync(customerId + request?.ToQueryString(), cancellationToken).ConfigureAwait(false);
        await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

        var customerResponse = await response.Content.ReadAsAsync<Customer>().ConfigureAwait(false);
        return customerResponse;
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
    public async Task<StoreCustomerResponse> GetResponseAsync(QueryableBaseRequest request = null, CancellationToken cancellationToken = default)
    {

        request ??= new QueryableBaseRequest
        {
            Limit = _limit
        };

        var requestUrl = string.Format(BaseUrl, StoreId);
        using var client = CreateMailClient(requestUrl);
        var response = await client.GetAsync(request.ToQueryString(), cancellationToken).ConfigureAwait(false);
        await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

        var customerResponse = await response.Content.ReadAsAsync<StoreCustomerResponse>().ConfigureAwait(false);
        return customerResponse;
    }

    /// <summary>
    /// The update async.
    /// </summary>
    /// <param name="customerId"></param>
    /// <param name="customer"></param>
    /// <returns>
    /// The <see cref="Task"/>.
    /// </returns>
    public async Task<Customer> UpdateAsync(string customerId, Customer customer, CancellationToken cancellationToken = default)
    {
        var requestUrl = string.Format(BaseUrl, StoreId);
        using var client = CreateMailClient(requestUrl + "/");
        var response = await client.PatchAsJsonAsync(customerId, customer, cancellationToken).ConfigureAwait(false);
        await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

        var customerResponse = await response.Content.ReadAsAsync<Customer>().ConfigureAwait(false);
        return customerResponse;
    }

    public string StoreId { get; set; }
}
