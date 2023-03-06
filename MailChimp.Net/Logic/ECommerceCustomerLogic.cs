// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ECommerceCustomerLogic.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;
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
    public async Task<Customer> AddAsync(Customer customer)
    {
        var requestUrl = string.Format(BaseUrl, StoreId);
        using var client = CreateMailClient(requestUrl);
        var response = await client.PostAsJsonAsync(string.Empty, customer).ConfigureAwait(false);
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
    public async Task DeleteAsync(string customerId)
    {
        var requestUrl = string.Format(BaseUrl, StoreId);
        using var client = CreateMailClient(requestUrl + "/");
        var response = await client.DeleteAsync(customerId).ConfigureAwait(false);
        await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
    }

    /// <summary>
    /// Gets only the customers from the response object
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    public async Task<IEnumerable<Customer>> GetAllAsync(QueryableBaseRequest request = null) => (await GetResponseAsync(request).ConfigureAwait(false))?.Customers;

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
    public async Task<Customer> GetAsync(string customerId, BaseRequest request = null)
    {
        var requestUrl = string.Format(BaseUrl, StoreId);

        using var client = CreateMailClient(requestUrl + "/");
        var response = await client.GetAsync(customerId + request?.ToQueryString()).ConfigureAwait(false);
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
    public async Task<StoreCustomerResponse> GetResponseAsync(QueryableBaseRequest request = null)
    {

        request ??= new QueryableBaseRequest
        {
            Limit = _limit
        };

        var requestUrl = string.Format(BaseUrl, StoreId);
        using var client = CreateMailClient(requestUrl);
        var response = await client.GetAsync(request.ToQueryString()).ConfigureAwait(false);
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
    public async Task<Customer> UpdateAsync(string customerId, Customer customer)
    {
        var requestUrl = string.Format(BaseUrl, StoreId);
        using var client = CreateMailClient(requestUrl + "/");
        var response = await client.PatchAsJsonAsync(customerId, customer).ConfigureAwait(false);
        await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

        var customerResponse = await response.Content.ReadAsAsync<Customer>().ConfigureAwait(false);
        return customerResponse;
    }

    public string StoreId { get; set; }
}
