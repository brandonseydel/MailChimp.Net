// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CampaignLogic.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using MailChimp.Net.Core;
using MailChimp.Net.Interfaces;
using MailChimp.Net.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
#pragma warning disable 1584, 1711, 1572, 1581, 1580

namespace MailChimp.Net.Logic
{
    /// <summary>
    /// The campaign logic.
    /// </summary>
    internal class CampaignLogic : BaseLogic, ICampaignLogic
	{

        public CampaignLogic(MailChimpOptions mailChimpConfiguration)
            : base(mailChimpConfiguration)
        {
        }

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
        /// <exception cref="ArgumentNullException"><paramref>
        ///         <name>uriString</name>
        ///     </paramref>
        ///     is null. </exception>
        /// <exception cref="MailChimpException">
        /// Custom Mail Chimp Exception
        /// </exception>
        /// <exception cref="UriFormatException">In the .NET for Windows Store apps or the Portable Class Library, catch the base class exception, <see cref="T:System.FormatException" />, instead.<paramref name="uriString" /> is empty.-or- The scheme specified in <paramref name="uriString" /> is not correctly formed. See <see cref="M:System.Uri.CheckSchemeName(System.String)" />.-or- <paramref name="uriString" /> contains too many slashes.-or- The password specified in <paramref name="uriString" /> is not valid.-or- The host name specified in <paramref name="uriString" /> is not valid.-or- The file name specified in <paramref name="uriString" /> is not valid. -or- The user name specified in <paramref name="uriString" /> is not valid.-or- The host or authority name specified in <paramref name="uriString" /> cannot be terminated by backslashes.-or- The port number specified in <paramref name="uriString" /> is not valid or cannot be parsed.-or- The length of <paramref name="uriString" /> exceeds 65519 characters.-or- The length of the scheme specified in <paramref name="uriString" /> exceeds 1023 characters.-or- There is an invalid character sequence in <paramref name="uriString" />.-or- The MS-DOS path specified in <paramref name="uriString" /> must start with c:\\.</exception>
        public async Task<Campaign> AddOrUpdateAsync(Campaign campaign)
		{
			if (string.IsNullOrWhiteSpace(campaign.Id))
			{
				return await CreateAsync(campaign).ConfigureAwait(false);
			}

			using (var client = CreateMailClient("campaigns/"))
			{
				var response = await client.PatchAsJsonAsync($"{campaign.Id}", campaign).ConfigureAwait(false);
				await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

				return await response.Content.ReadAsAsync<Campaign>().ConfigureAwait(false);
			}
		}
		public async Task<Campaign> AddAsync(Campaign campaign)
		{
			return await CreateAsync(campaign).ConfigureAwait(false);
		}
		public async Task<Campaign> UpdateAsync(string campaignId, Campaign campaign)
		{
			using (var client = CreateMailClient("campaigns/"))
			{
				var response = await client.PatchAsJsonAsync($"{campaignId}", campaign).ConfigureAwait(false);
				await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

				return await response.Content.ReadAsAsync<Campaign>().ConfigureAwait(false);
			}
		}

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
		/// <exception cref="ArgumentNullException"><paramref>
		///         <name>uriString</name>
		///     </paramref>
		///     is null. </exception>
		/// <exception cref="UriFormatException">In the .NET for Windows Store apps or the Portable Class Library, catch the base class exception, <see cref="T:System.FormatException" />, instead.<paramref name="uriString" /> is empty.-or- The scheme specified in <paramref name="uriString" /> is not correctly formed. See <see cref="M:System.Uri.CheckSchemeName(System.String)" />.-or- <paramref name="uriString" /> contains too many slashes.-or- The password specified in <paramref name="uriString" /> is not valid.-or- The host name specified in <paramref name="uriString" /> is not valid.-or- The file name specified in <paramref name="uriString" /> is not valid. -or- The user name specified in <paramref name="uriString" /> is not valid.-or- The host or authority name specified in <paramref name="uriString" /> cannot be terminated by backslashes.-or- The port number specified in <paramref name="uriString" /> is not valid or cannot be parsed.-or- The length of <paramref name="uriString" /> exceeds 65519 characters.-or- The length of the scheme specified in <paramref name="uriString" /> exceeds 1023 characters.-or- There is an invalid character sequence in <paramref name="uriString" />.-or- The MS-DOS path specified in <paramref name="uriString" /> must start with c:\\.</exception>
		/// <exception cref="MailChimpException">
		/// Custom Mail Chimp Exception
		/// </exception>
		[Obsolete]
		public async Task<Campaign> AddOrUpdateAsync(string campaignId, Campaign campaign)
		{
			if (!string.IsNullOrWhiteSpace(campaignId))
			{
				campaign.Id = campaignId;
			}

			if (string.IsNullOrWhiteSpace(campaign.Id))
			{
				return await CreateAsync(campaign).ConfigureAwait(false);
			}



			using (var client = CreateMailClient("campaigns/"))
			{
				var response = await client.PatchAsJsonAsync($"{campaign.Id}", campaign).ConfigureAwait(false);
				await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

				return await response.Content.ReadAsAsync<Campaign>().ConfigureAwait(false);
			}
		}


		private async Task<Campaign> CreateAsync(Campaign campaign)
		{
			using (var client = CreateMailClient("campaigns"))
			{
				var response = await client.PostAsJsonAsync("", campaign).ConfigureAwait(false);
				await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

				return await response.Content.ReadAsAsync<Campaign>().ConfigureAwait(false);
			}
		}

		/// <summary>
		/// The cancel async.
		/// </summary>
		/// <param name="campaignId">
		/// The campaign Id.
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
		/// <exception cref="MailChimpException">
		/// Custom Mail Chimp Exception
		/// </exception>
		public async Task CancelAsync(string campaignId)
		{
			using (var client = CreateMailClient("campaigns/"))
			{
				var response = await client.PostAsync($"{campaignId}/actions/cancel-send", null).ConfigureAwait(false);
				await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
			}
		}

		/// <summary>
		/// The delete async.
		/// </summary>
		/// <param name="campaignId">
		/// The campaign Id.
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
		/// <exception cref="InvalidOperationException">The request message was already sent by the <see cref="T:System.Net.Http.HttpClient" /> instance.</exception>
		/// <exception cref="MailChimpException">
		/// Custom Mail Chimp Exception
		/// </exception>
		public async Task DeleteAsync(string campaignId)
		{
			using (var client = CreateMailClient("campaigns/"))
			{
				var response = await client.DeleteAsync($"{campaignId}").ConfigureAwait(false);
				await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
			}
		}

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
		public async Task<IEnumerable<Campaign>> GetAll(CampaignRequest request = null)
		{
			return (await GetResponseAsync(request).ConfigureAwait(false))?.Campaigns;
		}

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
		public async Task<IEnumerable<Campaign>> GetAllAsync(CampaignRequest request = null)
		{
			return (await GetResponseAsync(request).ConfigureAwait(false))?.Campaigns;
		}


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
		public async Task<CampaignResponse> GetResponseAsync(CampaignRequest request = null)
		{
            request = request ?? new CampaignRequest
			{
				Limit = _limit
			};

			using (var client = CreateMailClient("campaigns"))
			{
				var response = await client.GetAsync(request.ToQueryString()).ConfigureAwait(false);
				await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

				var campaignResponse = await response.Content.ReadAsAsync<CampaignResponse>().ConfigureAwait(false);
				return campaignResponse;
			}
		}


		/// <summary>
		/// The get async.
		/// </summary>
		/// <param name="id">
		/// The id.
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
		/// <exception cref="MailChimpException">
		/// Custom Mail Chimp Exception
		/// </exception>
		public async Task<Campaign> GetAsync(string id)
		{
			using (var client = CreateMailClient("campaigns/"))
			{
				var dashboardLink = string.Empty;
				var response = await client.GetAsync($"{id}").ConfigureAwait(false);
				await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

				IEnumerable<string> linkValues;
				if (response.Headers.TryGetValues("Link", out linkValues))
				{
					var linkValue = linkValues?.FirstOrDefault();
					var dashboardLinkSection = linkValue?.Split(';').FirstOrDefault(x => x.Contains("show"));

					if (!string.IsNullOrWhiteSpace(dashboardLinkSection))
					{
						var indexOfFirstCarrot = dashboardLinkSection.IndexOf("<", StringComparison.Ordinal) + 1;
						var indexOfSecondCarrot = dashboardLinkSection.IndexOf(">", StringComparison.Ordinal);

						if (indexOfFirstCarrot > -1 && indexOfSecondCarrot > indexOfFirstCarrot)
						{
							dashboardLink = dashboardLinkSection.Substring(indexOfFirstCarrot, indexOfSecondCarrot - indexOfFirstCarrot);
						}
					}
				}

				var campaign = await response.Content.ReadAsAsync<Campaign>().ConfigureAwait(false);

				campaign.DashboardLink = dashboardLink;
				return campaign;
			}
		}

		/// <summary>
		/// The send async.
		/// </summary>
		/// <param name="campaignId">
		/// The campaign Id.
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
		/// <exception cref="MailChimpException">
		/// Custom Mail Chimp Exception
		/// </exception>
		public async Task SendAsync(string campaignId)
		{
			using (var client = CreateMailClient("campaigns/"))
			{
				var response = await client.PostAsync($"{campaignId}/actions/send", null).ConfigureAwait(false);
				await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
			}
		}

		public async Task ExecuteCampaignActionAsync(string campaignId, CampaignAction campaignAction)
		{

			var member = typeof(CampaignAction).GetRuntimeProperties().FirstOrDefault(x=>x.Name == (campaignAction.ToString()));
			var action =
				member.GetCustomAttributes(typeof(DescriptionAttribute), false)
					  .OfType<DescriptionAttribute>()
					  .FirstOrDefault()?.Description ?? campaignAction.ToString().ToLower();

			using (var client = CreateMailClient("campaigns/"))
			{
				var response = await client.PostAsync($"{campaignId}/actions/${action}", null).ConfigureAwait(false);
				await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
			}
		}

		public async Task<ReplicateResponse> ReplicateCampaignAsync(string campaignId)
		{

			using (var client = CreateMailClient("campaigns/"))
			{
				var response = await client.PostAsync($"{campaignId}/actions/replicate", null).ConfigureAwait(false);
				await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
				return await response.Content.ReadAsAsync<ReplicateResponse>().ConfigureAwait(false);
			}
		}


	    /// <summary>
	    /// The send test request async.
	    /// </summary>
	    /// <param name="campaignId">
	    /// The campaign Id.
	    /// </param>
	    /// <param name="content"></param>
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
	    /// <exception cref="MailChimpException">
	    /// Custom Mail Chimp Exception
	    /// </exception>
	    public async Task TestAsync(string campaignId, CampaignTestRequest content = null)
		{
			using (var client = CreateMailClient("campaigns/"))
			{
				var response = await client.PostAsJsonAsync($"{campaignId}/actions/test", content).ConfigureAwait(false);
				await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
			}
		}

	    /// <summary>
	    /// The send test request async.
	    /// </summary>
	    /// <param name="campaignId">
	    /// The campaign Id.
	    /// </param>
	    /// <param name="content"></param>
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
	    /// <exception cref="MailChimpException">
	    /// Custom Mail Chimp Exception
	    /// </exception>
	    public async Task ScheduleAsync(string campaignId, CampaignScheduleRequest content = null)
		{
			using (var client = CreateMailClient("campaigns/"))
			{
				var response = await client.PostAsJsonAsync($"{campaignId}/actions/schedule", content).ConfigureAwait(false);
				await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
			}
		}

        public async Task<CampaignSearchResult> SearchAsync(CampaignSearchRequest request = null)
        {
            using (var client = CreateMailClient($"search-campaigns{request?.ToQueryString()}"))
            {
                var response = await client.GetAsync("").ConfigureAwait(false);
                await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
                return await response.Content.ReadAsAsync<CampaignSearchResult>().ConfigureAwait(false);
            }
        }


        /// <summary>
        /// The send checklist async.
        /// </summary>
        /// <param name="id">
        /// The id.
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
        /// <exception cref="MailChimpException">
        /// Custom Mail Chimp Exception
        /// </exception>
        // ReSharper disable once UnusedMember.Global
        public async Task<SendChecklistResponse> SendChecklistAsync(string id)
		{
			using (var client = CreateMailClient("campaigns/"))
			{
				var response = await client.GetAsync($"{id}/send-checklist").ConfigureAwait(false);
				await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
				return await response.Content.ReadAsAsync<SendChecklistResponse>().ConfigureAwait(false);
			}
		}
	}
}