using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Interfaces;
using MailChimp.Net.Models;

namespace MailChimp.Net.Logic;

internal class SignupFormLogic : BaseLogic, ISignupFormLogic
{
    public SignupFormLogic(MailChimpOptions mailChimpConfiguration)
        : base(mailChimpConfiguration)
    {
    }

    public async Task<IEnumerable<SignupForm>> GetAllAsync(string listId, CancellationToken cancellationToken = default)
        => (await GetResponseAsync(listId, cancellationToken).ConfigureAwait(false))?.SignupForms;

    public async Task<SignupFormResponse> GetResponseAsync(string listId, CancellationToken cancellationToken = default)
    {
        using var client = CreateMailClient("lists/");
        var response = await client.GetAsync($"{listId}/signup-forms", cancellationToken).ConfigureAwait(false);
        await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
        return await response.Content.ReadAsAsync<SignupFormResponse>().ConfigureAwait(false);
    }

    public async Task<SignupForm> AddOrUpdateAsync(string listId, SignupForm signupForm, CancellationToken cancellationToken = default)
    {
        using var client = CreateMailClient("lists/");
        var response = await client.PostAsJsonAsync($"{listId}/signup-forms", signupForm, cancellationToken).ConfigureAwait(false);
        await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
        return await response.Content.ReadAsAsync<SignupForm>().ConfigureAwait(false);
    }
}
