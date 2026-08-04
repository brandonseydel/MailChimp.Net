using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Models;

namespace MailChimp.Net.Interfaces;

public interface IECommerceProductImageLogic
{
    string StoreId { get; set; }
    string ProductId { get; set; }
    Task<IEnumerable<Image>> GetAllAsync(QueryableBaseRequest request = null, CancellationToken cancellationToken = default);
    Task<ProductImageResponse> GetResponseAsync(QueryableBaseRequest request = null, CancellationToken cancellationToken = default);
    Task<Image> GetAsync(string imageId, BaseRequest request = null, CancellationToken cancellationToken = default);
    Task<Image> AddAsync(Image image, CancellationToken cancellationToken = default);
    Task<Image> UpdateAsync(string imageId, Image image, CancellationToken cancellationToken = default);
    Task DeleteAsync(string imageId, CancellationToken cancellationToken = default);
}
