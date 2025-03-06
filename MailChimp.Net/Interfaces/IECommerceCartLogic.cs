using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Models;

namespace MailChimp.Net.Interfaces
{
    public interface IECommerceCartLogic
    {
        IECommerceLineLogic Lines(string cartId);
        Task<Cart> AddAsync(Cart cart, CancellationToken cancellationToken = default);
        Task DeleteAsync(string cartId, CancellationToken cancellationToken = default);
        Task<IEnumerable<Cart>> GetAllAsync(QueryableBaseRequest request = null, CancellationToken cancellationToken = default);
        Task<Cart> GetAsync(string cartId, BaseRequest request = null, CancellationToken cancellationToken = default);
        Task<CartResponse> GetResponseAsync(QueryableBaseRequest request = null, CancellationToken cancellationToken = default);
        Task<Cart> UpdateAsync(string cartId, Cart cart, CancellationToken cancellationToken = default);
        string StoreId { get; set; }
    }
}