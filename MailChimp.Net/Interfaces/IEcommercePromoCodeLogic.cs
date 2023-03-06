using System.Collections.Generic;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Models;

namespace MailChimp.Net.Interfaces;

public interface IEcommercePromoCodeLogic
{
    Task<PromoCode> AddAsync(PromoCode promoCode);
    Task DeleteAsync(string promoCodeID);

    /// <summary>
    /// Gets only the carts from the response object
    /// </summary>
    /// <param name="storeId"></param>
    /// <param name="request"></param>
    /// <returns></returns>
    Task<IEnumerable<PromoCode>> GetAllAsync(QueryableBaseRequest request = null);

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
    Task<PromoCode> GetAsync(string promoCodeID, BaseRequest request = null);

    /// <summary>
    /// The get response async.
    /// </summary>
    /// <param name="request">
    /// The request.
    /// </param>
    /// <returns>
    /// The <see cref="Task"/>.
    /// </returns>
    Task<StorePromoCodeResponse> GetResponseAsync(QueryableBaseRequest request = null);

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
    Task<PromoCode> UpdateAsync(string promoCodeID, PromoCode promoCode);

    string ResourceId { get; set; }
    string StoreId { get; set; }
    string Resource { get; set; }
}
