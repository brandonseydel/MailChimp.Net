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
        Task<Queue> AddSubscriberAsync(string workflowId, string workflowEmailId, string emailAddress);

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
        Task<IEnumerable<Queue>> GetAllAsync(string workflowId, string workflowEmailId);

        /// <summary>
        /// The get async.
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
        Task<Queue> GetAsync(string workflowId, string workflowEmailId, string emailAddress);
    }
}