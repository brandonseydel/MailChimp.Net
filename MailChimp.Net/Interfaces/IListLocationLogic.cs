using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Models;

namespace MailChimp.Net.Interfaces;

public interface IListLocationLogic
{
    Task<IEnumerable<ListLocation>> GetAllAsync(string listId, QueryableBaseRequest request = null, CancellationToken cancellationToken = default);
    Task<ListLocationResponse> GetResponseAsync(string listId, QueryableBaseRequest request = null, CancellationToken cancellationToken = default);
}
