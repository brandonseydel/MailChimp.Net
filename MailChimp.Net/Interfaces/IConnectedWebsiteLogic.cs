using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MailChimp.Net.Models;

namespace MailChimp.Net.Interfaces;

public interface IConnectedWebsiteLogic
{
    Task<IEnumerable<Site>> GetAllAsync(CancellationToken cancellationToken = default);
    Task<Site> GetAsync(string connectedSiteId, CancellationToken cancellationToken = default);
    Task<Site> AddAsync(string foreignId, string domain, CancellationToken cancellationToken = default);
    Task DeleteAsync(string connectedSiteId, CancellationToken cancellationToken = default);
    Task VerifyScriptInstallationAsync(string connectedSiteId, CancellationToken cancellationToken = default);
    Task EnablePixelAsync(string connectedSiteId, CancellationToken cancellationToken = default);
    Task DisablePixelAsync(string connectedSiteId, CancellationToken cancellationToken = default);
}