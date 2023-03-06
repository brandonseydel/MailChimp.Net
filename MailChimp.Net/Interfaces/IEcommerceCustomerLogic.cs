using System.Collections.Generic;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Models;

namespace MailChimp.Net.Interfaces;

public interface IECommerceCustomerLogic
{
    Task<Customer> AddAsync(Customer customer);
    
    Task DeleteAsync(string customerId);
    
    Task<IEnumerable<Customer>> GetAllAsync(QueryableBaseRequest request = null);
    
    Task<Customer> GetAsync(string customerId, BaseRequest request = null);

    Task<StoreCustomerResponse> GetResponseAsync(QueryableBaseRequest request = null);

    Task<Customer> UpdateAsync(string customerId, Customer customer);

    string StoreId { get; set; }
}