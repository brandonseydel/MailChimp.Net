// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ICampaignLogic.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using MailChimp.Net.Core;
using MailChimp.Net.Models;

namespace MailChimp.Net.Interfaces
{
	/// <summary>
	/// The CampaignLogic interface.
	/// </summary>
	public interface ICampaignLogic
	{
		/// <summary>
		/// The add or update async.
		/// </summary>
		/// <param name="campaignId">
		/// The campaign id.
		/// </param>
		/// <param name="campaign">
		/// The campaign.
		/// </param>
		/// <returns>
		/// The <see cref="Task"/>.
		/// </returns>
		[Obsolete]
		Task<Campaign> AddOrUpdateAsync(string campaignId, Campaign campaign);

		/// <summary>
		/// The add or update async.
		/// </summary>
		/// <param name="campaign">
		/// The campaign.
		/// </param>
		/// <returns>
		/// The <see cref="Task"/>.
		/// </returns>
		Task<Campaign> AddOrUpdateAsync(Campaign campaign);
		Task<Campaign> AddAsync(Campaign campaign);
		Task<Campaign> UpdateAsync(string campaignId, Campaign campaign);
		Task<ReplicateResponse> ReplicateCampaignAsync(string campaignId);

		/// <summary>
		/// The cancel async.
		/// </summary>
		/// <param name="campaignId">
		/// The campaign id.
		/// </param>
		/// <returns>
		/// The <see cref="Task"/>.
		/// </returns>
		Task CancelAsync(string campaignId);

		/// <summary>
		/// The delete async.
		/// </summary>
		/// <param name="campaignId">
		/// The campaign id.
		/// </param>
		/// <returns>
		/// The <see cref="Task"/>.
		/// </returns>
		Task DeleteAsync(string campaignId);

		/// <summary>
		/// The get all.
		/// </summary>
		/// <param name="request">
		/// The request.
		/// </param>
		/// <returns>
		/// The <see cref="Task"/>.
		/// </returns>
		Task<IEnumerable<Campaign>> GetAll(CampaignRequest request = null);

		/// <summary>
		/// The get async.
		/// </summary>
		/// <param name="id">
		/// The id.
		/// </param>
		/// <returns>
		/// The <see cref="Task"/>.
		/// </returns>
		Task<Campaign> GetAsync(string id);

		/// <summary>
		/// The send async.
		/// </summary>
		/// <param name="campaignId">
		/// The campaign id.
		/// </param>
		/// <returns>
		/// The <see cref="Task"/>.
		/// </returns>
		Task SendAsync(string campaignId);

		/// <summary>
		/// Executes a given action on the specified campaign.
		/// </summary>
		/// <param name="campaignId"></param>
		/// <param name="campaignAction"></param>
		/// <returns></returns>
		Task ExecuteCampaignActionAsync(string campaignId, CampaignAction campaignAction);

		///<summary>
		/// The test async.
		/// </summary>
		/// <param name="campaignId">
		/// The campaign id.
		/// </param>
		/// <returns>
		/// The <see cref="Task"/>.
		/// </returns>
		Task TestAsync(string campaignId, CampaignTestRequest content = null);


		///<summary>
		/// The schedule async task.
		/// </summary>
		/// <param name="campaignId">
		/// The campaign id.
		/// </param>
		/// <returns>
		/// The <see cref="Task"/>.
		/// </returns>
		Task ScheduleAsync(string campaignId, CampaignScheduleRequest content = null);

        ///<summary>
		/// The unschedule async task.
		/// </summary>
		/// <param name="campaignId">
		/// The campaign id.
		/// </param>
		/// <returns>
		/// The <see cref="Task"/>.
		/// </returns>
		Task UnscheduleAsync(string campaignId, CampaignScheduleRequest content = null);


        /// <summary>
        /// The get all.
        /// </summary>
        /// <param name="request">
        /// The request.
        /// </param>
        /// <exception cref="ArgumentNullException">
        /// The <paramref>
        ///         <name>requestUri</name>
        ///     </paramref>
        ///     was null.
        /// </exception>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        /// <exception cref="UriFormatException">In the .NET for Windows Store apps or the Portable Class Library, catch the base class exception, <see cref="T:System.FormatException" />, instead.<paramref name="uriString" /> is empty.-or- The scheme specified in <paramref name="uriString" /> is not correctly formed. See <see cref="M:System.Uri.CheckSchemeName(System.String)" />.-or- <paramref name="uriString" /> contains too many slashes.-or- The password specified in <paramref name="uriString" /> is not valid.-or- The host name specified in <paramref name="uriString" /> is not valid.-or- The file name specified in <paramref name="uriString" /> is not valid. -or- The user name specified in <paramref name="uriString" /> is not valid.-or- The host or authority name specified in <paramref name="uriString" /> cannot be terminated by backslashes.-or- The port number specified in <paramref name="uriString" /> is not valid or cannot be parsed.-or- The length of <paramref name="uriString" /> exceeds 65519 characters.-or- The length of the scheme specified in <paramref name="uriString" /> exceeds 1023 characters.-or- There is an invalid character sequence in <paramref name="uriString" />.-or- The MS-DOS path specified in <paramref name="uriString" /> must start with c:\\.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Enlarging the value of this instance would exceed <see cref="P:System.Text.StringBuilder.MaxCapacity" />. </exception>
        /// <exception cref="MailChimpException">
        /// Custom Mail Chimp Exception
        /// </exception>
        /// <exception cref="NotSupportedException"><paramref name="element" /> is not a constructor, method, property, event, type, or field. </exception>
        /// <exception cref="TypeLoadException">A custom attribute type cannot be loaded. </exception>
        Task<IEnumerable<Campaign>> GetAllAsync(CampaignRequest request = null);

		/// <summary>
		/// The get all.
		/// </summary>
		/// <param name="request">
		/// The request.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// The <paramref>
		///         <name>requestUri</name>
		///     </paramref>
		///     was null.
		/// </exception>
		/// <returns>
		/// The <see cref="Task"/>.
		/// </returns>
		/// <exception cref="UriFormatException">In the .NET for Windows Store apps or the Portable Class Library, catch the base class exception, <see cref="T:System.FormatException" />, instead.<paramref name="uriString" /> is empty.-or- The scheme specified in <paramref name="uriString" /> is not correctly formed. See <see cref="M:System.Uri.CheckSchemeName(System.String)" />.-or- <paramref name="uriString" /> contains too many slashes.-or- The password specified in <paramref name="uriString" /> is not valid.-or- The host name specified in <paramref name="uriString" /> is not valid.-or- The file name specified in <paramref name="uriString" /> is not valid. -or- The user name specified in <paramref name="uriString" /> is not valid.-or- The host or authority name specified in <paramref name="uriString" /> cannot be terminated by backslashes.-or- The port number specified in <paramref name="uriString" /> is not valid or cannot be parsed.-or- The length of <paramref name="uriString" /> exceeds 65519 characters.-or- The length of the scheme specified in <paramref name="uriString" /> exceeds 1023 characters.-or- There is an invalid character sequence in <paramref name="uriString" />.-or- The MS-DOS path specified in <paramref name="uriString" /> must start with c:\\.</exception>
		/// <exception cref="ArgumentOutOfRangeException">Enlarging the value of this instance would exceed <see cref="P:System.Text.StringBuilder.MaxCapacity" />. </exception>
		/// <exception cref="MailChimpException">
		/// Custom Mail Chimp Exception
		/// </exception>
		/// <exception cref="NotSupportedException"><paramref name="element" /> is not a constructor, method, property, event, type, or field. </exception>
		/// <exception cref="TypeLoadException">A custom attribute type cannot be loaded. </exception>
		Task<CampaignResponse> GetResponseAsync(CampaignRequest request = null);
		Task<SendChecklistResponse> SendChecklistAsync(string id);
	}
}