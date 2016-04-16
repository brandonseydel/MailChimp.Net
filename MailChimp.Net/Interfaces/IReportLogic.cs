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
    using System;

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
        Task<IEnumerable<Report>> GetAllReportsAsync(ReportRequest request = null);

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

        /// <summary>
        /// The get all reports async.
        /// </summary>
        /// <param name="request">
        /// The request.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        /// <exception cref="ArgumentNullException"><paramref>
        ///         <name>uriString</name>
        ///     </paramref>
        ///     is null. </exception>
        /// <exception cref="UriFormatException">In the .NET for Windows Store apps or the Portable Class Library, catch the base class exception, <see cref="T:System.FormatException" />, instead.<paramref name="uriString" /> is empty.-or- The scheme specified in <paramref name="uriString" /> is not correctly formed. See <see cref="M:System.Uri.CheckSchemeName(System.String)" />.-or- <paramref name="uriString" /> contains too many slashes.-or- The password specified in <paramref name="uriString" /> is not valid.-or- The host name specified in <paramref name="uriString" /> is not valid.-or- The file name specified in <paramref name="uriString" /> is not valid. -or- The user name specified in <paramref name="uriString" /> is not valid.-or- The host or authority name specified in <paramref name="uriString" /> cannot be terminated by backslashes.-or- The port number specified in <paramref name="uriString" /> is not valid or cannot be parsed.-or- The length of <paramref name="uriString" /> exceeds 65519 characters.-or- The length of the scheme specified in <paramref name="uriString" /> exceeds 1023 characters.-or- There is an invalid character sequence in <paramref name="uriString" />.-or- The MS-DOS path specified in <paramref name="uriString" /> must start with c:\\.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Enlarging the value of this instance would exceed <see cref="P:System.Text.StringBuilder.MaxCapacity" />. </exception>
        /// <exception cref="MailChimpException">
        /// Custom Mail Chimp Exception
        /// </exception>
        /// <exception cref="NotSupportedException"><paramref name="element" /> is not a constructor, method, property, event, type, or field. </exception>
        /// <exception cref="TypeLoadException">A custom attribute type cannot be loaded. </exception>
        Task<ReportResponse> GetResponseAsync(ReportRequest request = null);
    }
}