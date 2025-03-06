using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Models;

namespace MailChimp.Net.Interfaces
{
    public interface IECommerceProductVarianceLogic
    {
        string BaseUrl { get; }
        string ProductId { get; set; }
        string StoreId { get; set; }
        Task<Variant> AddAsync(Variant variant, CancellationToken cancellationToken = default);
        Task DeleteAsync(string variantId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets only the carts from the response object
        /// </summary>
        /// <param name="storeId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<IEnumerable<Variant>> GetAllAsync(QueryableBaseRequest request = null, CancellationToken cancellationToken = default);

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
        Task<Variant> GetAsync(string variantId, BaseRequest request = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// The get response async.
        /// </summary>
        /// <param name="request">
        /// The request.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<ProductVariantResponse> GetResponseAsync(QueryableBaseRequest request = null, CancellationToken cancellationToken = default);

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
        Task<Variant> UpdateAsync(string variantId, Variant variant, CancellationToken cancellationToken = default);
    }
}
