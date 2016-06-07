using System.Collections.Generic;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Models;

namespace MailChimp.Net.Interfaces
{
    public interface IECommerceCartLogic
    {
        Task<Cart> AddAsync(string storeId, Cart cart);
        Task DeleteAsync(string storeId, string cartId);
        Task<IEnumerable<Cart>> GetAllAsync(string storeId, QueryableBaseRequest request = null);
        Task<Cart> GetAsync(string storeId, string cartId, BaseRequest request = null);
        Task<CartResponse> GetResponseAsync(string storeId, QueryableBaseRequest request = null);
        Task<Cart> UpdateAsync(string storeId, string cartId, Cart cart);
    }
}