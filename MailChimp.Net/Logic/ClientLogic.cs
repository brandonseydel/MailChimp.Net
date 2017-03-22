// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ClientLogic.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using MailChimp.Net.Core;
using MailChimp.Net.Interfaces;
using MailChimp.Net.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
#pragma warning disable 1584,1711,1572,1581,1580

namespace MailChimp.Net.Logic
{
    /// <summary>
    /// The client logic.
    /// </summary>
    public class ClientLogic : BaseLogic, IClientLogic
	{

        public ClientLogic(IMailChimpConfiguration mailChimpConfiguration)
            : base(mailChimpConfiguration)
        {
        }

        /// <summary>
        /// The get all async.
        /// </summary>
        /// <param name="listId">
        /// The list id.
        /// </param>
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
        public async Task<IEnumerable<Client>> GetAllAsync(string listId, BaseRequest request = null)
		{
			return (await this.GetResponseAsync(listId, request).ConfigureAwait(false))?.Clients;			
		}

		/// <summary>
		/// The get all async.
		/// </summary>
		/// <param name="listId">
		/// The list id.
		/// </param>
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
		public async Task<ClientResponse> GetResponseAsync(string listId, BaseRequest request = null)
		{
			using (var client = this.CreateMailClient("lists/"))
			{
				var response = await client.GetAsync($"{listId}/clients{request?.ToQueryString()}").ConfigureAwait(false);
				await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

				var appResponse = await response.Content.ReadAsAsync<ClientResponse>().ConfigureAwait(false);
				return appResponse;
			}
		}


	}
}