// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IAutomationLogic.cs" company="Brandon Seydel">
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
    /// The AutomationLogic interface.
    /// </summary>
    public interface IAutomationLogic
    {
        /// <summary>
        /// The get all async.
        /// </summary>
        /// <param name="request">
        /// The request.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<IEnumerable<Automation>> GetAllAsync(BaseRequest request = null);

        /// <summary>
        /// The get async.
        /// </summary>
        /// <param name="workflowId">
        /// The workflow id.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<Automation> GetAsync(string workflowId);

        /// <summary>
        /// The pause async.
        /// </summary>
        /// <param name="workflowId">
        /// The workflow id.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task PauseAsync(string workflowId);

        /// <summary>
        /// The start async.
        /// </summary>
        /// <param name="workflowId">
        /// The workflow id.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task StartAsync(string workflowId);
    }
}