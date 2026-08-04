using System.Threading;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Interfaces;
using MailChimp.Net.Models;

namespace MailChimp.Net.Logic;

internal class CustomerJourneyLogic : BaseLogic, ICustomerJourneyLogic
{
    public CustomerJourneyLogic(MailChimpOptions mailChimpConfiguration)
        : base(mailChimpConfiguration)
    {
    }

    public Task TriggerAsync(string journeyId, string stepId, string emailAddress, CancellationToken cancellationToken = default)
        => TriggerAsync(journeyId, stepId, new CustomerJourneyTriggerRequest { EmailAddress = emailAddress }, cancellationToken);

    public async Task TriggerAsync(string journeyId, string stepId, CustomerJourneyTriggerRequest request, CancellationToken cancellationToken = default)
    {
        using var client = CreateMailClient("customer-journeys/journeys/");
        var response = await client.PostAsJsonAsync($"{journeyId}/steps/{stepId}/actions/trigger", request, cancellationToken).ConfigureAwait(false);
        await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
    }
}
