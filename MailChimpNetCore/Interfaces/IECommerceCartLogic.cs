using System.Collections.Generic;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Models;

namespace MailChimp.Net.Interfaces
{
    public interface IECommerceCartLogic
    {
        IECommerceLineLogic Lines(string cartId);
        Task<Cart> AddAsync(Cart cart);
        Task DeleteAsync(string cartId);
        Task<IEnumerable<Cart>> GetAllAsync(QueryableBaseRequest request = null);
        Task<Cart> GetAsync(string cartId, BaseRequest request = null);
        Task<CartResponse> GetResponseAsync(QueryableBaseRequest request = null);
        Task<Cart> UpdateAsync(string cartId, Cart cart);
        string StoreId { get; set; }
    }
}