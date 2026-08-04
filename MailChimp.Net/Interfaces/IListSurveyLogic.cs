using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Models;

namespace MailChimp.Net.Interfaces;

public interface IListSurveyLogic
{
    Task<IEnumerable<Survey>> GetAllAsync(string listId, QueryableBaseRequest request = null, CancellationToken cancellationToken = default);
    Task<SurveyResponse> GetResponseAsync(string listId, QueryableBaseRequest request = null, CancellationToken cancellationToken = default);
    Task<Survey> GetAsync(string listId, string surveyId, CancellationToken cancellationToken = default);
    Task<Survey> AddAsync(string listId, Survey survey, CancellationToken cancellationToken = default);
    Task<Survey> UpdateAsync(string listId, string surveyId, Survey survey, CancellationToken cancellationToken = default);
    Task DeleteAsync(string listId, string surveyId, CancellationToken cancellationToken = default);
    Task PublishAsync(string listId, string surveyId, CancellationToken cancellationToken = default);
    Task UnpublishAsync(string listId, string surveyId, CancellationToken cancellationToken = default);
    Task CreateEmailAsync(string listId, string surveyId, CancellationToken cancellationToken = default);
    Task ReplicateAsync(string listId, string surveyId, CancellationToken cancellationToken = default);
}
