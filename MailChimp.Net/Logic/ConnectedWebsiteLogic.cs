using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    public ConnectedWebsiteLogic(MailChimpOptions mailChimpConfiguration)
        : base(mailChimpConfiguration)
    {
    }

    public async Task<Site> AddAsync(string foreignId, string domain, CancellationToken cancellationToken = default)
    {
        using var client = CreateMailClient("/connected-sites");

        var postRequst = new ConnectedWebsiteRequest { domain = domain, foreign_id = foreignId };
        var response = await client.PostAsJsonAsync("", postRequst, cancellationToken).ConfigureAwait(false);
        await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

        return await response.Content.ReadAsAsync<Site>().ConfigureAwait(false);
    }

    public async Task<IEnumerable<Site>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        using var client = CreateMailClient("/connected-sites");
        
        var response = await client.GetAsync("", cancellationToken);
        await response.EnsureSuccessMailChimpAsync();

        var appResponse = await response.Content.ReadAsAsync<ConnectedWebsiteResponse>().ConfigureAwait(false);
        return appResponse?.Sites;
    }
}