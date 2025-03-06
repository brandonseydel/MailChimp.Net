// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IAutomationEmailQueueLogic.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Threading.Tasks;

using MailChimp.Net.Models;

namespace MailChimp.Net.Interfaces
{
    using System.Threading;
    using Core;

    /// <summary>
    /// The AutomationEmailQueueLogic interface.
    /// </summary>
    public interface IAutomationEmailQueueLogic
    {
        /// <summary>
        /// The add subscriber async.
        /// </summary>
        /// <param name="workflowId">
        /// The workflow id.
        /// </param>
        /// <param name="workflowEmailId">
        /// The workflow email id.
        /// </param>
        /// <param name="emailAddress">
        /// The email address.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<Queue> AddSubscriberAsync(string workflowId, string workflowEmailId, string emailAddress, CancellationToken cancellationToken = default);

        /// <summary>
        /// The get all async.
        /// </summary>
        /// <param name="workflowId">
        /// The workflow id.
        /// </param>
        /// <param name="workflowEmailId">
        /// The workflow email id.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<IEnumerable<Queue>> GetAllAsync(string workflowId, string workflowEmailId, CancellationToken cancellationToken = default);

        /// <summary>
        /// The get async.
        /// </summary>
        /// <param name="workflowId">
        /// The workflow id.
        /// </param>
        /// <param name="workflowEmailId">
        /// The workflow email id.
        /// </param>
        /// <param name="emailAddressOrHash">
        /// The email address.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<Queue> GetAsync(string workflowId, string workflowEmailId, string emailAddressOrHash, CancellationToken cancellationToken = default);

        /// <summary>
        /// The get all async.
        /// </summary>
        /// <param name="workflowId">
        /// The workflow id.
        /// </param>
        /// <param name="workflowEmailId">
        /// The workflow email id.
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
        Task<AutomationEmailQueueResponse> GetResponseAsync(string workflowId, string workflowEmailId, CancellationToken cancellationToken = default);
    }
}