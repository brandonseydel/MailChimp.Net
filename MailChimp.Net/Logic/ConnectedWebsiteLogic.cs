using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Core.Requests;
using MailChimp.Net.Core.Responses;
using MailChimp.Net.Interfaces;
using MailChimp.Net.Models;

namespace MailChimp.Net.Logic;

internal class ConnectedWebsiteLogic : BaseLogic, IConnectedWebsiteLogic
{
    private const string BaseUrl = "connected-sites";

    public ConnectedWebsiteLogic(MailChimpOptions mailChimpConfiguration)
        : base(mailChimpConfiguration)
    {
    }

    public async Task<Site> AddAsync(string foreignId, string domain, CancellationToken cancellationToken = default)
    {
        using var client = CreateMailClient(BaseUrl);
        var postRequest = new ConnectedWebsiteRequest { domain = domain, foreign_id = foreignId };
        var response = await client.PostAsJsonAsync(string.Empty, postRequest, cancellationToken).ConfigureAwait(false);
        await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
        return await response.Content.ReadAsAsync<Site>().ConfigureAwait(false);
    }

    public async Task<IEnumerable<Site>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        using var client = CreateMailClient(BaseUrl);
        var response = await client.GetAsync(string.Empty, cancellationToken).ConfigureAwait(false);
        await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
        var appResponse = await response.Content.ReadAsAsync<ConnectedWebsiteResponse>().ConfigureAwait(false);
        return appResponse?.Sites;
    }

    public async Task<Site> GetAsync(string connectedSiteId, CancellationToken cancellationToken = default)
    {
        using var client = CreateMailClient($"{BaseUrl}/");
        var response = await client.GetAsync(connectedSiteId, cancellationToken).ConfigureAwait(false);
        await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
        return await response.Content.ReadAsAsync<Site>().ConfigureAwait(false);
    }

    public async Task DeleteAsync(string connectedSiteId, CancellationToken cancellationToken = default)
    {
        using var client = CreateMailClient($"{BaseUrl}/");
        var response = await client.DeleteAsync(connectedSiteId, cancellationToken).ConfigureAwait(false);
        await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
    }

    public async Task VerifyScriptInstallationAsync(string connectedSiteId, CancellationToken cancellationToken = default)
    {
        using var client = CreateMailClient($"{BaseUrl}/");
        var response = await client.PostAsync($"{connectedSiteId}/actions/verify-script-installation", null, cancellationToken).ConfigureAwait(false);
        await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
    }

    public async Task EnablePixelAsync(string connectedSiteId, CancellationToken cancellationToken = default)
    {
        using var client = CreateMailClient($"{BaseUrl}/");
        var response = await client.PostAsync($"{connectedSiteId}/actions/enable-pixel", null, cancellationToken).ConfigureAwait(false);
        await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
    }

    public async Task DisablePixelAsync(string connectedSiteId, CancellationToken cancellationToken = default)
    {
        using var client = CreateMailClient($"{BaseUrl}/");
        var response = await client.PostAsync($"{connectedSiteId}/actions/disable-pixel", null, cancellationToken).ConfigureAwait(false);
        await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
    }
}
