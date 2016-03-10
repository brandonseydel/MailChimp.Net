// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IAutomationSubscriberLogic.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Threading.Tasks;

using MailChimp.Net.Models;

namespace MailChimp.Net.Interfaces
{
    /// <summary>
    /// The AutomationSubscriberLogic interface.
    /// </summary>
    public interface IAutomationSubscriberLogic
    {
        /// <summary>
        /// The get removed subscribers async.
        /// </summary>
        /// <param name="workflowId">
        /// The workflow id.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<IEnumerable<Subscriber>> GetRemovedSubscribersAsync(string workflowId);

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
        Task<Subscriber> RemoveSubscriberAsync(string workflowId, string emailAddress);
    }
}