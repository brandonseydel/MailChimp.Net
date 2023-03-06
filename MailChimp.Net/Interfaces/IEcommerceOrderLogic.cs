using System.Collections.Generic;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Models;

namespace MailChimp.Net.Interfaces;

public interface IECommerceOrderLogic
{
    /// <summary>
    /// Adds a order to the given store by id
    /// </summary>
    /// <param name="storeId"></param>
    /// <param name="order"></param>
    /// <returns></returns>
    Task<Order> AddAsync(Order order);

    IECommerceLineLogic Lines(string orderId);

    /// <summary>
    /// The delete async.
    /// </summary>
    /// <param name="storeId">
    /// The store id.
    /// </param>
    /// <returns>
    /// The <see cref="Task"/>.
    /// </returns>
    Task DeleteAsync(string orderId);

    /// <summary>
    /// Gets only the orders from the response object
    /// </summary>
    /// <param name="storeId"></param>
    /// <param name="request"></param>
    /// <returns></returns>
    Task<IEnumerable<Order>> GetAllAsync(OrderRequest request = null);

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
    Task<Order> GetAsync(string orderId, BaseRequest request = null);

    /// <summary>
    /// The get response async.
    /// </summary>
    /// <param name="request">
    /// The request.
    /// </param>
    /// <returns>
    /// The <see cref="Task"/>.
    /// </returns>
    Task<StoreOrderResponse> GetResponseAsync(OrderRequest request = null);

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
    Task<Order> UpdateAsync(string orderId, Order order);

    string StoreId { get; set; }
}