using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Interfaces;
using MailChimp.Net.Models;

namespace MailChimp.Net.Logic;

internal class VerifiedDomainLogic : BaseLogic, IVerifiedDomainLogic
{
    private const string BaseUrl = "verified-domains";

    public VerifiedDomainLogic(MailChimpOptions mailChimpConfiguration)
        : base(mailChimpConfiguration)
    {
    }

    public async Task<IEnumerable<VerifiedDomain>> GetAllAsync(QueryableBaseRequest request = null, CancellationToken cancellationToken = default)
        => (await GetResponseAsync(request, cancellationToken).ConfigureAwait(false))?.Domains;

    public async Task<VerifiedDomainResponse> GetResponseAsync(QueryableBaseRequest request = null, CancellationToken cancellationToken = default)
    {
        request ??= new QueryableBaseRequest { Limit = _limit };
        using var client = CreateMailClient(BaseUrl);
        var response = await client.GetAsync(request.ToQueryString(), cancellationToken).ConfigureAwait(false);
        await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
        return await response.Content.ReadAsAsync<VerifiedDomainResponse>().ConfigureAwait(false);
    }

    public async Task<VerifiedDomain> GetAsync(string domainName, CancellationToken cancellationToken = default)
    {
        using var client = CreateMailClient($"{BaseUrl}/");
        var response = await client.GetAsync(domainName, cancellationToken).ConfigureAwait(false);
        await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
        return await response.Content.ReadAsAsync<VerifiedDomain>().ConfigureAwait(false);
    }

    public async Task<VerifiedDomain> AddAsync(string domainName, string verificationEmail = null, CancellationToken cancellationToken = default)
    {
        using var client = CreateMailClient(BaseUrl);
        var body = new { domain = domainName, verification_email = verificationEmail };
        var response = await client.PostAsJsonAsync(string.Empty, body, cancellationToken).ConfigureAwait(false);
        await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
        return await response.Content.ReadAsAsync<VerifiedDomain>().ConfigureAwait(false);
    }

    public async Task DeleteAsync(string domainName, CancellationToken cancellationToken = default)
    {
        using var client = CreateMailClient($"{BaseUrl}/");
        var response = await client.DeleteAsync(domainName, cancellationToken).ConfigureAwait(false);
        await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
    }

    public async Task<VerifiedDomain> VerifyAsync(string domainName, string code = null, CancellationToken cancellationToken = default)
    {
        using var client = CreateMailClient($"{BaseUrl}/");
        var body = code == null ? null : new { code };
        var response = body == null
            ? await client.PostAsync($"{domainName}/actions/verify", null, cancellationToken).ConfigureAwait(false)
            : await client.PostAsJsonAsync($"{domainName}/actions/verify", body, cancellationToken).ConfigureAwait(false);
        await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
        return await response.Content.ReadAsAsync<VerifiedDomain>().ConfigureAwait(false);
    }
}
