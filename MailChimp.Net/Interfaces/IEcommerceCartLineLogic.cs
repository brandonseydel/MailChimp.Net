using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Models;

namespace MailChimp.Net.Interfaces;

public interface IECommerceLineLogic
{
    Task<Line> AddAsync(Line line, CancellationToken cancellationToken = default);
    Task DeleteAsync(string lineId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets only the carts from the response object
    /// </summary>
    /// <param name="storeId"></param>
    /// <param name="request"></param>
    /// <returns></returns>
    Task<IEnumerable<Line>> GetAllAsync(QueryableBaseRequest request = null, CancellationToken cancellationToken = default);

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
    Task<Line> GetAsync(string lineId, BaseRequest request = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// The get response async.
    /// </summary>
    /// <param name="request">
    /// The request.
    /// </param>
    /// <returns>
    /// The <see cref="Task"/>.
    /// </returns>
    Task<CartLineResponse> GetResponseAsync(QueryableBaseRequest request = null, CancellationToken cancellationToken = default);

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
    Task<Line> UpdateAsync(string lineId, Line line, CancellationToken cancellationToken = default);

    string ResourceId { get; set; }
    string StoreId { get; set; }
    string Resource { get; set; }
}
