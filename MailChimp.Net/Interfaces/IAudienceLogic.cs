using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Models;

namespace MailChimp.Net.Interfaces;

/// <summary>
/// Audiences Endpoints (BETA). Available for evaluation/testing; subject to change by Mailchimp.
/// </summary>
public interface IAudienceLogic
{
    Task<IEnumerable<Audience>> GetAllAsync(QueryableBaseRequest request = null, CancellationToken cancellationToken = default);
    Task<AudienceResponse> GetResponseAsync(QueryableBaseRequest request = null, CancellationToken cancellationToken = default);
    Task<Audience> GetAsync(string audienceId, CancellationToken cancellationToken = default);

    Task<IEnumerable<AudienceContact>> GetContactsAsync(string audienceId, QueryableBaseRequest request = null, CancellationToken cancellationToken = default);
    Task<AudienceContactResponse> GetContactsResponseAsync(string audienceId, QueryableBaseRequest request = null, CancellationToken cancellationToken = default);
    Task<AudienceContact> GetContactAsync(string audienceId, string contactId, CancellationToken cancellationToken = default);
    Task<AudienceContact> AddContactAsync(string audienceId, AudienceContact contact, CancellationToken cancellationToken = default);
    Task<AudienceContact> UpdateContactAsync(string audienceId, string contactId, AudienceContact contact, CancellationToken cancellationToken = default);
    Task ArchiveContactAsync(string audienceId, string contactId, CancellationToken cancellationToken = default);
    Task ForgetContactAsync(string audienceId, string contactId, CancellationToken cancellationToken = default);
}
