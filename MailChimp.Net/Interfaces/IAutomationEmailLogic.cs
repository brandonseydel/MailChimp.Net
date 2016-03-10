// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IAutomationEmailLogic.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Threading.Tasks;

using MailChimp.Net.Models;

namespace MailChimp.Net.Interfaces
{
    /// <summary>
    /// The AutomationEmailLogic interface.
    /// </summary>
    public interface IAutomationEmailLogic
    {
        /// <summary>
        /// The get all async.
        /// </summary>
        /// <param name="workflowId">
        /// The workflow id.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<IEnumerable<Email>> GetAllAsync(string workflowId);

        /// <summary>
        /// The get async.
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
        Task<Email> GetAsync(string workflowId, string workflowEmailId);

        /// <summary>
        /// The pause async.
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
        Task PauseAsync(string workflowId, string workflowEmailId);

        /// <summary>
        /// The start async.
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
        Task StartAsync(string workflowId, string workflowEmailId);
    }
}