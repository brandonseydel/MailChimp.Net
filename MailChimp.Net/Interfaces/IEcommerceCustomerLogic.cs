using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Models;

namespace MailChimp.Net.Interfaces;

public interface IECommerceCustomerLogic
{
    Task<Customer> AddAsync(Customer customer, CancellationToken cancellationToken = default);
    
    Task DeleteAsync(string customerId, CancellationToken cancellationToken = default);
    
    Task<IEnumerable<Customer>> GetAllAsync(QueryableBaseRequest request = null, CancellationToken cancellationToken = default);
    
    Task<Customer> GetAsync(string customerId, BaseRequest request = null, CancellationToken cancellationToken = default);

    Task<StoreCustomerResponse> GetResponseAsync(QueryableBaseRequest request = null, CancellationToken cancellationToken = default);

    Task<Customer> UpdateAsync(string customerId, Customer customer, CancellationToken cancellationToken = default);

    string StoreId { get; set; }
}