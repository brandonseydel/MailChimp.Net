using System.Collections.Generic;
using MailChimp.Net.Models;
namespace MailChimp.Net.Core;

public class StorePromoRuleResponse : BaseResponse
{

    public StorePromoRuleResponse()
    {
        PromoRules = new List<PromoRule>();
    }

    [MailChimpJsonProperty("store_id")]
    public string StoreId { get; set; }

    [MailChimpJsonProperty("promo_rules")]
    public IList<PromoRule> PromoRules { get; set; }
}
