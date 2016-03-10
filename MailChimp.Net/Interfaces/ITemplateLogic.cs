// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ITemplateLogic.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Threading.Tasks;

using MailChimp.Net.Core;
using MailChimp.Net.Models;

namespace MailChimp.Net.Interfaces
{
    /// <summary>
    /// The TemplateLogic interface.
    /// </summary>
    public interface ITemplateLogic
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
        Task<IEnumerable<Template>> GetAllAsync(TemplateRequest request);

        /// <summary>
        /// The get async.
        /// </summary>
        /// <param name="templateId">
        /// The template id.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<Template> GetAsync(string templateId);
    }
}