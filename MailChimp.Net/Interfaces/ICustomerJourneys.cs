using System.Threading.Tasks;

namespace MailChimp.Net.Interfaces
{
    /// <summary>
    /// The CustomerJourneys logic
    /// https://mailchimp.com/developer/marketing/api/customer-journeys-journeys-steps-actions/
    /// </summary>
    public interface ICustomerJourneys
    {
        /// <summary>
        /// Triggers the journey step for the given emailAddress.
        /// </summary>
        /// <param name="journeyId">The id for the Journey.</param>
        /// <param name="stepId">The id for the Step.</param>
        /// <param name="emailAddress">The list member's email address.</param>
        /// <returns></returns>
        Task TriggerAsync(int journeyId, int stepId, string emailAddress);
    }
}