using System.Collections.Generic;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Models;

namespace MailChimp.Net.Interfaces
{
    public interface IECommerceProductLogic
    {
        string StoreId { get; set; }

        /// <summary>
        /// Adds a product to the given store by id
        /// </summary>
        /// <param name="storeId"></param>
        /// <param name="product"></param>
        /// <returns></returns>
        Task<Product> AddAsync(Product product);

        Task DeleteAsync(string productId);

        /// <summary>
        /// Gets only the products from the response object
        /// </summary>
        /// <param name="storeId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<IEnumerable<Product>> GetAllAsync(QueryableBaseRequest request = null);

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
        Task<Product> GetAsync(string productId, BaseRequest request = null);

        /// <summary>
        /// The get response async.
        /// </summary>
        /// <param name="request">
        /// The request.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<StoreProductResponse> GetResponseAsync(QueryableBaseRequest request = null);

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
        Task<Product> UpdateAsync(string productId, Product product);
    }
}