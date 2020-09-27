// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IApiLogic.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Threading.Tasks;

using MailChimp.Net.Models;

namespace MailChimp.Net.Interfaces
{
    /// <summary>
    /// The ApiLogic interface.
    /// </summary>
    public interface IApiLogic
    {
        /// <summary>
        /// The get info.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<ApiInfo> GetInfoAsync();

        Task<Ping> PingAsync();
    }
}