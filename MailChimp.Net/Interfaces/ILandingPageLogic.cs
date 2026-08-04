using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Models;

namespace MailChimp.Net.Interfaces;

public interface ILandingPageLogic
{
    Task<IEnumerable<LandingPage>> GetAllAsync(QueryableBaseRequest request = null, CancellationToken cancellationToken = default);
    Task<LandingPageResponse> GetResponseAsync(QueryableBaseRequest request = null, CancellationToken cancellationToken = default);
    Task<LandingPage> GetAsync(string pageId, BaseRequest request = null, CancellationToken cancellationToken = default);
    Task<LandingPage> AddAsync(LandingPage landingPage, CancellationToken cancellationToken = default);
    Task<LandingPage> UpdateAsync(string pageId, LandingPage landingPage, CancellationToken cancellationToken = default);
    Task DeleteAsync(string pageId, CancellationToken cancellationToken = default);
    Task PublishAsync(string pageId, CancellationToken cancellationToken = default);
    Task UnpublishAsync(string pageId, CancellationToken cancellationToken = default);
    Task<LandingPageContent> GetContentAsync(string pageId, CancellationToken cancellationToken = default);
}
