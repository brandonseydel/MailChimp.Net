using System.Collections.Generic;
using MailChimp.Net.Models;
using Newtonsoft.Json;

namespace MailChimp.Net.Core;

public class StorePromoCodeResponse
{
    public StorePromoCodeResponse()
    {
        PromoCodes = new List<PromoCode>();
    }

    [JsonProperty("store_id")]
    public string StoreId { get; set; }

    [JsonProperty("promo_codes")]
    public IList<PromoCode> PromoCodes { get; set; }
}
