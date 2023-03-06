using System.Collections.Generic;
using System.Threading.Tasks;

using MailChimp.Net.Core;
using MailChimp.Net.Models;

namespace MailChimp.Net.Interfaces;

public interface IECommerceLogic
{
    IECommerceCartLogic Carts(string storeId);
    IECommerceCustomerLogic Customers(string storeId);
    IECommerceProductLogic Products(string storeId);
    IECommerceOrderLogic Orders(string storeId);
    IECommercePromoRuleLogic PromoRules(string storeId);

    /// <summary>
    /// The add async.
    /// </summary>
    /// <param name="store">
    /// The store.
    /// </param>
    /// <returns>
    /// The <see cref="Task"/>.
    /// </returns>
    Task<Store> AddAsync(Store store);

    /// <summary>
    /// The delete async.
    /// </summary>
    /// <param name="storeId">
    /// The store id.
    /// </param>
    /// <returns>
    /// The <see cref="Task"/>.
    /// </returns>
    Task DeleteAsync(string storeId);

    /// <summary>
    /// The get all async.
    /// </summary>
    /// <param name="request">
    /// The request.
    /// </param>
    /// <returns>
    /// The <see cref="Task"/>.
    /// </returns>
    Task<IEnumerable<Store>> GetAllAsync(QueryableBaseRequest request = null);

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
    Task<Store> GetAsync(string storeId, BaseRequest request = null);

    /// <summary>
    /// The get response async.
    /// </summary>
    /// <param name="request">
    /// The request.
    /// </param>
    /// <returns>
    /// The <see cref="Task"/>.
    /// </returns>
    Task<ECommerceResponse> GetResponseAsync(QueryableBaseRequest request = null);

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
    Task<Store> UpdateAsync(string storeId, Store store);
}
