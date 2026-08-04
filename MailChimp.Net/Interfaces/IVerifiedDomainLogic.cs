using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Models;

namespace MailChimp.Net.Interfaces;

public interface IVerifiedDomainLogic
{
    Task<IEnumerable<VerifiedDomain>> GetAllAsync(QueryableBaseRequest request = null, CancellationToken cancellationToken = default);
    Task<VerifiedDomainResponse> GetResponseAsync(QueryableBaseRequest request = null, CancellationToken cancellationToken = default);
    Task<VerifiedDomain> GetAsync(string domainName, CancellationToken cancellationToken = default);
    Task<VerifiedDomain> AddAsync(string domainName, string verificationEmail = null, CancellationToken cancellationToken = default);
    Task DeleteAsync(string domainName, CancellationToken cancellationToken = default);
    Task<VerifiedDomain> VerifyAsync(string domainName, string code = null, CancellationToken cancellationToken = default);
}
