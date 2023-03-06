using System.Collections.Generic;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Models;

namespace MailChimp.Net.Interfaces;

public interface IECommercePromoRuleLogic
{
    Task<PromoRule> AddAsync(PromoRule promoRule);
    Task DeleteAsync(string promoRuleID);
    Task<IEnumerable<PromoRule>> GetAllAsync(QueryableBaseRequest request = null);
    Task<PromoRule> GetAsync(string promoRuleId, BaseRequest request = null);
    IEcommercePromoCodeLogic Codes(string promoRuleID);
    Task<StorePromoRuleResponse> GetResponseAsync(QueryableBaseRequest request = null);
    Task<PromoRule> UpdateAsync(string promoRuleID, PromoRule promoRule);

    string StoreId { get; set; }
}