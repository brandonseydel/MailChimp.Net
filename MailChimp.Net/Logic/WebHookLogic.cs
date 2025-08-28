// --------------------------------------------------------------------------------------------------------------------
// <copyright file="WebHookLogic.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Interfaces;
using MailChimp.Net.Models;

namespace MailChimp.Net.Logic;

/// <summary>
/// The web hook logic.
/// </summary>
public class WebHookLogic : BaseLogic, IWebHookLogic
{
    /// <summary>
    /// The base url.
    /// </summary>
    private const string BaseUrl = "/lists/{0}/webhooks";

    public WebHookLogic(MailChimpOptions mailChimpConfiguration)
        : base(mailChimpConfiguration)
    {
    }

    /// <summary>
    /// The add async.
    /// </summary>
    /// <param name="listId">
    /// The list id.
    /// </param>
    /// <param name="webhook">
    /// Webhook.
    /// </param>
    /// <returns>
    /// The <see cref="Task"/>.
    /// </returns>
    public async Task<WebHook> AddAsync(string listId, WebHook webhook, CancellationToken cancellationToken = default)
    {
        using var client = CreateMailClient(string.Format(BaseUrl, listId));
        var response = await client.PostAsJsonAsync(string.Empty, webhook, cancellationToken).ConfigureAwait(false);
        await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

        var webHookResponse = await response.Content.ReadAsAsync<WebHook>().ConfigureAwait(false);
        return webHookResponse;
    }

    /// <summary>
    /// The delete async.
    /// </summary>
    /// <param name="listId">
    /// The list id.
    /// </param>
    /// <param name="webhookId">
    /// The webhook id.
    /// </param>
    /// <returns>
    /// The <see cref="Task"/>.
    /// </returns>
    public async Task DeleteAsync(string listId, string webhookId, CancellationToken cancellationToken = default)
    {
        using var client = CreateMailClient(string.Format(BaseUrl + "/", listId));
        var response = await client.DeleteAsync(webhookId, cancellationToken).ConfigureAwait(false);
        await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
    }

    /// <summary>
    /// The get all async.
    /// </summary>
    /// <param name="listId">
    /// The list id.
    /// </param>
    /// <returns>
    /// The <see cref="Task"/>.
    /// </returns>
    public async Task<IEnumerable<WebHook>> GetAllAsync(string listId, CancellationToken cancellationToken = default) 
        => (await GetResponseAsync(listId, cancellationToken).ConfigureAwait(false))?.Webhooks;

    /// <summary>
    /// The get async.
    /// </summary>
    /// <param name="listId">
    /// The list id.
    /// </param>
    /// <param name="webhookId">
    /// The webhook id.
    /// </param>
    /// <returns>
    /// The <see cref="Task"/>.
    /// </returns>
    public async Task<WebHook> GetAsync(string listId, string webhookId, CancellationToken cancellationToken = default)
    {
        using var client = CreateMailClient(string.Format(BaseUrl + "/", listId));
        var response = await client.GetAsync(webhookId, cancellationToken).ConfigureAwait(false);
        await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

        var webHookResponse = await response.Content.ReadAsAsync<WebHook>().ConfigureAwait(false);
        return webHookResponse;
    }

    /// <summary>
    /// The get response async.
    /// </summary>
    /// <param name="listId">
    /// The list id.
    /// </param>
    /// <returns>
    /// The <see cref="Task"/>.
    /// </returns>
    public async Task<WebHookResponse> GetResponseAsync(string listId, CancellationToken cancellationToken = default)
    {
        using var client = CreateMailClient(string.Format(BaseUrl, listId));
        var response = await client.GetAsync(string.Empty, cancellationToken).ConfigureAwait(false);
        await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

        var mergeResponse = await response.Content.ReadAsAsync<WebHookResponse>().ConfigureAwait(false);
        return mergeResponse;
    }

    /// <summary>
    /// The update async.
    /// </summary>
    /// <param name="listId">
    /// The list id.
    /// </param>
    /// <param name="mergeField">
    /// The merge field.
    /// </param>
    /// <param name="mergeId">
    /// The merge id.
    /// </param>
    /// <returns>
    /// The <see cref="Task"/>.
    /// </returns>
    public async Task<MergeField> UpdateAsync(string listId, MergeField mergeField, int? mergeId = null, CancellationToken cancellationToken = default)
    {
        using var client = CreateMailClient(string.Format(BaseUrl + "/", listId));
        var response = await client.PatchAsJsonAsync((mergeId ?? mergeField.MergeId).ToString(), mergeField, cancellationToken).ConfigureAwait(false);
        await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

        var mergeResponse = await response.Content.ReadAsAsync<MergeField>().ConfigureAwait(false);
        return mergeResponse;
    }
}
