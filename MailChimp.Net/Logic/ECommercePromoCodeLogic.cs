using System.Collections.Generic;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Interfaces;
using MailChimp.Net.Models;

namespace MailChimp.Net.Logic;

internal class ECommercePromoCodeLogic : BaseLogic, IEcommercePromoCodeLogic
{
    public string BaseUrl => $"ecommerce/stores/{StoreId}/{Resource}/{ResourceId}/promo-codes";

    public ECommercePromoCodeLogic(MailChimpOptions mailChimpConfiguration)
        : base(mailChimpConfiguration)
    {
    }

    public async Task<PromoCode> AddAsync(PromoCode promoCode)
    {
        using var client = CreateMailClient(BaseUrl);
        var response = await client.PostAsJsonAsync(string.Empty, promoCode).ConfigureAwait(false);
        await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

        var cartResponse = await response.Content.ReadAsAsync<PromoCode>().ConfigureAwait(false);
        return cartResponse;
    }
    
    public async Task DeleteAsync(string promoCodeID)
    {
        using var client = CreateMailClient(BaseUrl + "/");
        var response = await client.DeleteAsync(promoCodeID).ConfigureAwait(false);
        await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
    }

    /// <summary>
    /// Gets only the carts from the response object
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    public async Task<IEnumerable<PromoCode>> GetAllAsync(QueryableBaseRequest request = null)
    {
        return (await GetResponseAsync(request).ConfigureAwait(false))?.PromoCodes;
    }

    /// <summary>
    /// The get async.
    /// </summary>
    /// <param name="lineId"></param>
    /// <param name="request">
    /// The request.
    /// </param>
    /// <returns>
    /// The <see cref="Task"/>.
    /// </returns>
    public async Task<PromoCode> GetAsync(string promoCodeID, BaseRequest request = null)
    {

        using var client = CreateMailClient(BaseUrl + "/");
        var response = await client.GetAsync(promoCodeID + request?.ToQueryString()).ConfigureAwait(false);
        await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

        var lineResponse = await response.Content.ReadAsAsync<PromoCode>().ConfigureAwait(false);
        return lineResponse;
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
    public async Task<StorePromoCodeResponse> GetResponseAsync(QueryableBaseRequest request = null)
    {

        request ??= new QueryableBaseRequest
        {
            Limit = _limit
        };

        using var client = CreateMailClient(BaseUrl);
        var response = await client.GetAsync(request.ToQueryString()).ConfigureAwait(false);
        await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

        var codeResponse = await response.Content.ReadAsAsync<StorePromoCodeResponse>().ConfigureAwait(false);
        return codeResponse;
    }

    /// <summary>
    /// The update async.
    /// </summary>
    /// <returns>
    /// The <see cref="Task"/>.
    /// </returns>
    public async Task<PromoCode> UpdateAsync(string promoCodeID, PromoCode promoCode)
    {
        using var client = CreateMailClient(BaseUrl + "/");
        var response = await client.PatchAsJsonAsync(promoCodeID, promoCode).ConfigureAwait(false);
        await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

        var cartResponse = await response.Content.ReadAsAsync<PromoCode>().ConfigureAwait(false);
        return cartResponse;
    }

    public string Resource { get; set; }
    public string ResourceId { get; set; }
    public string StoreId { get; set; }
}
