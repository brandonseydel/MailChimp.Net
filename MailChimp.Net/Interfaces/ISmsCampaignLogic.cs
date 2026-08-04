using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Models;

namespace MailChimp.Net.Interfaces;

public interface ISmsCampaignLogic
{
    Task<IEnumerable<SmsCampaign>> GetAllAsync(QueryableBaseRequest request = null, CancellationToken cancellationToken = default);
    Task<SmsCampaignResponse> GetResponseAsync(QueryableBaseRequest request = null, CancellationToken cancellationToken = default);
    Task<SmsCampaign> GetAsync(string smsCampaignId, BaseRequest request = null, CancellationToken cancellationToken = default);
    Task<SmsCampaign> AddAsync(SmsCampaign smsCampaign, CancellationToken cancellationToken = default);
    Task<SmsCampaign> UpdateAsync(string smsCampaignId, SmsCampaign smsCampaign, CancellationToken cancellationToken = default);
    Task DeleteAsync(string smsCampaignId, CancellationToken cancellationToken = default);
    Task CancelSendAsync(string smsCampaignId, CancellationToken cancellationToken = default);
    Task SendAsync(string smsCampaignId, CancellationToken cancellationToken = default);
    Task ScheduleAsync(string smsCampaignId, SmsCampaignScheduleRequest request = null, CancellationToken cancellationToken = default);
    Task<SmsCampaignContent> GetContentAsync(string smsCampaignId, CancellationToken cancellationToken = default);
    Task<SmsCampaignContent> SetContentAsync(string smsCampaignId, SmsCampaignContent content, CancellationToken cancellationToken = default);
}
