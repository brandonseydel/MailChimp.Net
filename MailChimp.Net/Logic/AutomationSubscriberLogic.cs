// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AutomationSubscriberLogic.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

<<<<<<< HEAD
using System.Collections.Generic;
using static System.Net.Http.HttpContentExtensions;
using System.Threading.Tasks;

=======
>>>>>>> pr/203
using MailChimp.Net.Core;
using MailChimp.Net.Interfaces;
using MailChimp.Net.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
#pragma warning disable 1584,1711,1572,1581,1580

namespace MailChimp.Net.Logic
{
    /// <summary>
    /// The automation subscriber logic.
    /// </summary>
    internal class AutomationSubscriberLogic : BaseLogic, IAutomationSubscriberLogic
    {

        public AutomationSubscriberLogic(MailchimpOptions mailChimpConfiguration)
            : base(mailChimpConfiguration)
        {
        }

        /// <summary>
        /// The get removed subscribers async.
        /// </summary>
        /// <param name="workflowId">
        /// The workflow id.
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
        public async Task<IEnumerable<Subscriber>> GetRemovedSubscribersAsync(string workflowId)
        {
            using (var client = CreateMailClient("automations/"))
            {
                var response = await client.GetAsync($"{workflowId}/removed-subscribers").ConfigureAwait(false);
                await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
                var automationResponse = await response.Content.ReadAsAsync<AutomationSubscriberResponse>().ConfigureAwait(false);
                return automationResponse.Subscribers;
            }
        }


        /// <summary>
        /// The get removed subscribers async.
        /// </summary>
        /// <param name="workflowId">
        /// The workflow id.
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
        public async Task<AutomationSubscriberResponse> GetRemovedSubscribersResponseAsync(string workflowId)
        {
            using (var client = CreateMailClient("automations/"))
            {
                var response = await client.GetAsync($"{workflowId}/removed-subscribers").ConfigureAwait(false);
                await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
                var automationResponse = await response.Content.ReadAsAsync<AutomationSubscriberResponse>().ConfigureAwait(false);
                return automationResponse;
            }
        }


        /// <summary>
        /// The remove subscriber async.
        /// </summary>
        /// <param name="workflowId">
        /// The workflow id.
        /// </param>
        /// <param name="emailAddress">
        /// The email address.
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
        public async Task<Subscriber> RemoveSubscriberAsync(string workflowId, string emailAddress)
        {
            using (var client = CreateMailClient("automations/"))
            {
                var response =
                    await
                    client.PostAsJsonAsync($"{workflowId}/removed-subscribers", new { email_address = emailAddress }).ConfigureAwait(false);
                await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
                return await response.Content.ReadAsAsync<Subscriber>().ConfigureAwait(false);
            }
        }
    }
}