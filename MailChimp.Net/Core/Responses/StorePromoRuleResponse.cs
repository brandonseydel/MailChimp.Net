using System.Collections.Generic;
using MailChimp.Net.Models;
using Newtonsoft.Json;

namespace MailChimp.Net.Core;

public class StorePromoRuleResponse : BaseResponse
{

    public StorePromoRuleResponse()
    {
        PromoRules = new List<PromoRule>();
    }

    [JsonProperty("store_id")]
    public string StoreId { get; set; }

    [JsonProperty("promo_rules")]
    public IList<PromoRule> PromoRules { get; set; }
}
