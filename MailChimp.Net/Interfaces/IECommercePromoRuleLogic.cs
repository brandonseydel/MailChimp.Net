using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Models;

namespace MailChimp.Net.Interfaces
{
    public interface IECommercePromoRuleLogic
    {
        Task<PromoRule> AddAsync(PromoRule promoRule, CancellationToken cancellationToken = default);
        Task DeleteAsync(string promoRuleID, CancellationToken cancellationToken = default);
        Task<IEnumerable<PromoRule>> GetAllAsync(QueryableBaseRequest request = null, CancellationToken cancellationToken = default);
        Task<PromoRule> GetAsync(string promoRuleId, BaseRequest request = null, CancellationToken cancellationToken = default);
        IEcommercePromoCodeLogic Codes(string promoRuleID);
        Task<StorePromoRuleResponse> GetResponseAsync(QueryableBaseRequest request = null, CancellationToken cancellationToken = default);
        Task<PromoRule> UpdateAsync(string promoRuleID, PromoRule promoRule, CancellationToken cancellationToken = default);

        string StoreId { get; set; }
    }
}