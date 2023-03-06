// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ActivityLogic.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Interfaces;
using MailChimp.Net.Models;

namespace MailChimp.Net.Logic;

/// <summary>
/// The activity logic.
/// </summary>
public class ActivityLogic : BaseLogic, IActivityLogic
{

    public ActivityLogic(MailChimpOptions mailChimpConfiguration)
        : base(mailChimpConfiguration)
    {
    }

    /// <summary>
    /// The get all async.
    /// </summary>
    /// <param name="listId">
    /// The list Id.
    /// </param>
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
    public async Task<IEnumerable<Activity>> GetAllAsync(string listId, BaseRequest request = null)
    {
        return (await GetResponseAsync(listId, request).ConfigureAwait(false))?.Activities;
    }

    /// <summary>
    /// The get all async.
    /// </summary>
    /// <param name="listId">
    /// The list Id.
    /// </param>
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
    public async Task<ActivityResponse> GetResponseAsync(string listId, BaseRequest request = null)
    {
        using var client = CreateMailClient("lists/");
        var response = await client.GetAsync($"{listId}/activity{request?.ToQueryString()}").ConfigureAwait(false);
        await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

        var appResponse = await response.Content.ReadAsAsync<ActivityResponse>().ConfigureAwait(false);
        return appResponse;
    }

    /// <inheritdoc />
    public async Task<ChimpChatterResponse> GetChimpChatterResponseAsync(QueryableBaseRequest request = null)
    {
        using var client = CreateMailClient("activity-feed/");
        var response = await client.GetAsync($"chimp-chatter{request?.ToQueryString()}").ConfigureAwait(false);
        await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

        var appResponse = await response.Content.ReadAsAsync<ChimpChatterResponse>().ConfigureAwait(false);
        return appResponse;
    }
}