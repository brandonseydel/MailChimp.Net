using System.Collections.Generic;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Models;

namespace MailChimp.Net.Interfaces
{
    public interface IReportLogic
    {
        Task<IEnumerable<Report>> GetAllReportsAsync(ReportRequest request);
        Task<IEnumerable<Advice>> GetCampaignAdviceAsync(BaseRequest request, string campaignId);
        Task<IEnumerable<UrlClicked>> GetClickReportAsync(QueryableBaseRequest request, string campaignId);
        Task<UrlClicked> GetClickReportDetailsAsync(BaseRequest request, string campaignId, string linkId);
        Task<ClickMember> GetClickReportMemberAsync(BaseRequest request, string campaignId, string linkId, string emailAddress);
        Task<IEnumerable<ClickMember>> GetClickReportMembersAsync(QueryableBaseRequest request, string campaignId, string linkId);
        Task<IEnumerable<Domain>> GetDomainPerformanceAsync(BaseRequest request, string campaignId);
        Task<EepUrlActivity> GetEepUrlReportAsync(BaseRequest request, string campaignId);
        Task<IEnumerable<EmailActivity>> GetEmailActivitiesAsync(QueryableBaseRequest request, string campaignId);
        Task<EmailActivity> GetEmailActivityAsync(BaseRequest request, string campaignId, string emailAddress);
        Task<IEnumerable<OpenLocation>> GetLocationsAsync(BaseRequest request, string campaignId);
        Task<Report> GetReportAsync(BaseRequest request, string campaignId);
        Task<SentTo> GetSentToRecipientAsync(QueryableBaseRequest request, string campaignId, string emailAddress);
        Task<IEnumerable<SentTo>> GetSentToRecipientsAsync(QueryableBaseRequest request, string campaignId);
        Task<IEnumerable<Report>> GetSubReportAsync(BaseRequest request, string campaignId);
        Task<Unsubscribe> GetUnsubscriberAsync(BaseRequest request, string campaignId, string emailAddress);
        Task<IEnumerable<Unsubscribe>> GetUnsubscribesAsync(QueryableBaseRequest request, string campaignId);
    }
}