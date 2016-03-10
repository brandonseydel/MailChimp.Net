// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IReportLogic.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Threading.Tasks;

using MailChimp.Net.Core;
using MailChimp.Net.Models;

namespace MailChimp.Net.Interfaces
{
    /// <summary>
    /// The ReportLogic interface.
    /// </summary>
    public interface IReportLogic
    {
        /// <summary>
        /// The get all reports async.
        /// </summary>
        /// <param name="request">
        /// The request.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<IEnumerable<Report>> GetAllReportsAsync(ReportRequest request);

        /// <summary>
        /// The get campaign advice async.
        /// </summary>
        /// <param name="request">
        /// The request.
        /// </param>
        /// <param name="campaignId">
        /// The campaign id.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<IEnumerable<Advice>> GetCampaignAdviceAsync(BaseRequest request, string campaignId);

        /// <summary>
        /// The get click report async.
        /// </summary>
        /// <param name="request">
        /// The request.
        /// </param>
        /// <param name="campaignId">
        /// The campaign id.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<IEnumerable<UrlClicked>> GetClickReportAsync(QueryableBaseRequest request, string campaignId);

        /// <summary>
        /// The get click report details async.
        /// </summary>
        /// <param name="request">
        /// The request.
        /// </param>
        /// <param name="campaignId">
        /// The campaign id.
        /// </param>
        /// <param name="linkId">
        /// The link id.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<UrlClicked> GetClickReportDetailsAsync(BaseRequest request, string campaignId, string linkId);

        /// <summary>
        /// The get click report member async.
        /// </summary>
        /// <param name="request">
        /// The request.
        /// </param>
        /// <param name="campaignId">
        /// The campaign id.
        /// </param>
        /// <param name="linkId">
        /// The link id.
        /// </param>
        /// <param name="emailAddress">
        /// The email address.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<ClickMember> GetClickReportMemberAsync(
            BaseRequest request, 
            string campaignId, 
            string linkId, 
            string emailAddress);

        /// <summary>
        /// The get click report members async.
        /// </summary>
        /// <param name="request">
        /// The request.
        /// </param>
        /// <param name="campaignId">
        /// The campaign id.
        /// </param>
        /// <param name="linkId">
        /// The link id.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<IEnumerable<ClickMember>> GetClickReportMembersAsync(
            QueryableBaseRequest request, 
            string campaignId, 
            string linkId);

        /// <summary>
        /// The get domain performance async.
        /// </summary>
        /// <param name="request">
        /// The request.
        /// </param>
        /// <param name="campaignId">
        /// The campaign id.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<IEnumerable<Domain>> GetDomainPerformanceAsync(BaseRequest request, string campaignId);

        /// <summary>
        /// The get eep url report async.
        /// </summary>
        /// <param name="request">
        /// The request.
        /// </param>
        /// <param name="campaignId">
        /// The campaign id.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<EepUrlActivity> GetEepUrlReportAsync(BaseRequest request, string campaignId);

        /// <summary>
        /// The get email activities async.
        /// </summary>
        /// <param name="request">
        /// The request.
        /// </param>
        /// <param name="campaignId">
        /// The campaign id.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<IEnumerable<EmailActivity>> GetEmailActivitiesAsync(QueryableBaseRequest request, string campaignId);

        /// <summary>
        /// The get email activity async.
        /// </summary>
        /// <param name="request">
        /// The request.
        /// </param>
        /// <param name="campaignId">
        /// The campaign id.
        /// </param>
        /// <param name="emailAddress">
        /// The email address.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<EmailActivity> GetEmailActivityAsync(BaseRequest request, string campaignId, string emailAddress);

        /// <summary>
        /// The get locations async.
        /// </summary>
        /// <param name="request">
        /// The request.
        /// </param>
        /// <param name="campaignId">
        /// The campaign id.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<IEnumerable<OpenLocation>> GetLocationsAsync(BaseRequest request, string campaignId);

        /// <summary>
        /// The get report async.
        /// </summary>
        /// <param name="request">
        /// The request.
        /// </param>
        /// <param name="campaignId">
        /// The campaign id.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<Report> GetReportAsync(BaseRequest request, string campaignId);

        /// <summary>
        /// The get sent to recipient async.
        /// </summary>
        /// <param name="request">
        /// The request.
        /// </param>
        /// <param name="campaignId">
        /// The campaign id.
        /// </param>
        /// <param name="emailAddress">
        /// The email address.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<SentTo> GetSentToRecipientAsync(QueryableBaseRequest request, string campaignId, string emailAddress);

        /// <summary>
        /// The get sent to recipients async.
        /// </summary>
        /// <param name="request">
        /// The request.
        /// </param>
        /// <param name="campaignId">
        /// The campaign id.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<IEnumerable<SentTo>> GetSentToRecipientsAsync(QueryableBaseRequest request, string campaignId);

        /// <summary>
        /// The get sub report async.
        /// </summary>
        /// <param name="request">
        /// The request.
        /// </param>
        /// <param name="campaignId">
        /// The campaign id.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<IEnumerable<Report>> GetSubReportAsync(BaseRequest request, string campaignId);

        /// <summary>
        /// The get unsubscriber async.
        /// </summary>
        /// <param name="request">
        /// The request.
        /// </param>
        /// <param name="campaignId">
        /// The campaign id.
        /// </param>
        /// <param name="emailAddress">
        /// The email address.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<Unsubscribe> GetUnsubscriberAsync(BaseRequest request, string campaignId, string emailAddress);

        /// <summary>
        /// The get unsubscribes async.
        /// </summary>
        /// <param name="request">
        /// The request.
        /// </param>
        /// <param name="campaignId">
        /// The campaign id.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<IEnumerable<Unsubscribe>> GetUnsubscribesAsync(QueryableBaseRequest request, string campaignId);
    }
}