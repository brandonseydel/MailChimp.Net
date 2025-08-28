using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Models;

namespace MailChimp.Net.Interfaces;

public interface IECommerceProductLogic
{
    string StoreId { get; set; }

    /// <summary>
    /// Adds a product to the given store by id
    /// </summary>
    /// <param name="storeId"></param>
    /// <param name="product"></param>
    /// <returns></returns>
    Task<Product> AddAsync(Product product, CancellationToken cancellationToken = default);

    Task DeleteAsync(string productId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets only the products from the response object
    /// </summary>
    /// <param name="storeId"></param>
    /// <param name="request"></param>
    /// <returns></returns>
    Task<IEnumerable<Product>> GetAllAsync(QueryableBaseRequest request = null, CancellationToken cancellationToken = default);

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
    Task<Product> GetAsync(string productId, BaseRequest request = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// The get response async.
    /// </summary>
    /// <param name="request">
    /// The request.
    /// </param>
    /// <returns>
    /// The <see cref="Task"/>.
    /// </returns>
    Task<StoreProductResponse> GetResponseAsync(QueryableBaseRequest request = null, CancellationToken cancellationToken = default);

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
    Task<Product> UpdateAsync(string productId, Product product, CancellationToken cancellationToken = default);

    IECommerceProductVarianceLogic Variances(string productId);
}