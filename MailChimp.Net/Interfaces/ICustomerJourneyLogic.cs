using System.Threading;
using System.Threading.Tasks;
using MailChimp.Net.Models;

namespace MailChimp.Net.Interfaces;

public interface ICustomerJourneyLogic
{
    /// <summary>
    /// Trigger a step in an Automation flow (Customer Journey) for a contact.
    /// </summary>
    Task TriggerAsync(string journeyId, string stepId, string emailAddress, CancellationToken cancellationToken = default);

    /// <summary>
    /// Trigger a step in an Automation flow (Customer Journey) for a contact.
    /// </summary>
    Task TriggerAsync(string journeyId, string stepId, CustomerJourneyTriggerRequest request, CancellationToken cancellationToken = default);
}
