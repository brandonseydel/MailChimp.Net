// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IReportLogic.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

using MailChimp.Net.Core;
using MailChimp.Net.Models;

namespace MailChimp.Net.Interfaces;

/// <summary>
/// The ReportLogic interface.
/// </summary>
public interface IReportLogic
{
    Task<AbuseReportResponse> GetAbuseReportsAsync(string campaignId, BaseRequest request = null, CancellationToken cancellationToken = default);
    Task<AbuseReport> GetAbuseReportAsync(string campaignId, string reportId, BaseRequest request = null, CancellationToken cancellationToken = default);
    Task<SentToResponse> GetSentToRecipientsResponseAsync(string campaignId, QueryableBaseRequest request = null, CancellationToken cancellationToken = default);
    Task<IEnumerable<Report>> GetAllReportsAsync(ReportRequest request = null, CancellationToken cancellationToken = default);
    Task<IEnumerable<Advice>> GetCampaignAdviceAsync(string campaignId, BaseRequest request = null, CancellationToken cancellationToken = default);
    Task<IEnumerable<Open>> GetCampaignOpenReportAsync(string campaignId, QueryableBaseRequest request = null, CancellationToken cancellationToken = default);
    Task<int> GetCampaignOpenReportCountAsync(string campaignId, QueryableBaseRequest request = null, CancellationToken cancellationToken = default);
    Task<IEnumerable<UrlClicked>> GetClickReportAsync(string campaignId, QueryableBaseRequest request = null, CancellationToken cancellationToken = default);
    Task<UrlClicked> GetClickReportDetailsAsync(string campaignId, string linkId, BaseRequest request = null, CancellationToken cancellationToken = default);
    Task<ClickMember> GetClickReportMemberAsync(string campaignId, string linkId, string emailAddressOrHash, BaseRequest request = null, CancellationToken cancellationToken = default);
    Task<IEnumerable<ClickMember>> GetClickReportMembersAsync(string campaignId, string linkId, QueryableBaseRequest request = null, CancellationToken cancellationToken = default);
    Task<IEnumerable<Domain>> GetDomainPerformanceAsync(string campaignId, BaseRequest request = null, CancellationToken cancellationToken = default);
    Task<EepUrlActivity> GetEepUrlReportAsync(string campaignId, BaseRequest request = null, CancellationToken cancellationToken = default);
    Task<IEnumerable<EmailActivity>> GetEmailActivitiesAsync(string campaignId, QueryableBaseRequest request = null, CancellationToken cancellationToken = default);
    Task<EmailResponse> GetEmailActivitiesResponseAsync(string campaignId, QueryableBaseRequest request = null, CancellationToken cancellationToken = default);
    Task<EmailActivity> GetEmailActivityAsync(string campaignId, string emailAddressOrHash, BaseRequest request = null, CancellationToken cancellationToken = default);
    Task<IEnumerable<OpenLocation>> GetLocationsAsync(string campaignId, BaseRequest request = null, CancellationToken cancellationToken = default);
    Task<Report> GetReportAsync(string campaignId, BaseRequest request = null, CancellationToken cancellationToken = default);
    Task<ReportResponse> GetResponseAsync(ReportRequest request = null, CancellationToken cancellationToken = default);
    Task<SentTo> GetSentToRecipientAsync(string campaignId, string emailAddressOrHash, QueryableBaseRequest request = null, CancellationToken cancellationToken = default);
    Task<IEnumerable<SentTo>> GetSentToRecipientsAsync(string campaignId, QueryableBaseRequest request = null, CancellationToken cancellationToken = default);
    Task<IEnumerable<Report>> GetSubReportAsync(string campaignId, BaseRequest request = null, CancellationToken cancellationToken = default);
    Task<Unsubscribe> GetUnsubscriberAsync(string campaignId, string emailAddressOrHash, BaseRequest request = null, CancellationToken cancellationToken = default);
    Task<IEnumerable<Unsubscribe>> GetUnsubscribesAsync(string campaignId, QueryableBaseRequest request = null, CancellationToken cancellationToken = default);
    Task<int> GetUnsubscribesCountAsync(string campaignId, QueryableBaseRequest request = null, CancellationToken cancellationToken = default);
}