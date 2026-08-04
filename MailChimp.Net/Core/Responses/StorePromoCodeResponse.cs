using System.Collections.Generic;
using MailChimp.Net.Models;
namespace MailChimp.Net.Core;

public class StorePromoCodeResponse
{
    public StorePromoCodeResponse()
    {
        PromoCodes = new List<PromoCode>();
    }

    [MailChimpJsonProperty("store_id")]
    public string StoreId { get; set; }

    [MailChimpJsonProperty("promo_codes")]
    public IList<PromoCode> PromoCodes { get; set; }
}
