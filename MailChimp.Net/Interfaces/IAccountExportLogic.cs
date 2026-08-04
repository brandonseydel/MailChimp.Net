using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Models;

namespace MailChimp.Net.Interfaces;

public interface IAccountExportLogic
{
    Task<IEnumerable<AccountExport>> GetAllAsync(QueryableBaseRequest request = null, CancellationToken cancellationToken = default);
    Task<AccountExportResponse> GetResponseAsync(QueryableBaseRequest request = null, CancellationToken cancellationToken = default);
    Task<AccountExport> GetAsync(string exportId, CancellationToken cancellationToken = default);
    Task<AccountExport> AddAsync(AccountExportRequest request = null, CancellationToken cancellationToken = default);
}
