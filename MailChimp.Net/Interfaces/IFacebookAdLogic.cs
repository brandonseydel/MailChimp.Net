using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Models;

namespace MailChimp.Net.Interfaces;

public interface IFacebookAdLogic
{
    Task<IEnumerable<FacebookAd>> GetAllAsync(QueryableBaseRequest request = null, CancellationToken cancellationToken = default);
    Task<FacebookAdResponse> GetResponseAsync(QueryableBaseRequest request = null, CancellationToken cancellationToken = default);
    Task<FacebookAd> GetAsync(string outreachId, BaseRequest request = null, CancellationToken cancellationToken = default);
}
