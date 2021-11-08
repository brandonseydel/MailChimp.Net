using System;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Interfaces;

namespace MailChimp.Net.Logic
{
    internal class CustomerJourneysLogic : BaseLogic, ICustomerJourneys
    {
        public CustomerJourneysLogic(MailChimpOptions mailChimpConfiguration)
            : base(mailChimpConfiguration)
        {
        }

        /// <summary>
        /// Trigger async.
        /// </summary>
        /// <param name="journeyId">The journey to trigger.</param>
        /// <param name="stepId">The step to trigger in the journey.</param>
        /// <param name="emailAddress">The email address to trigger the step for.</param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        /// <exception cref="ArgumentException"><paramref>
        ///         <name>emailAddress</name>
        ///     </paramref>
        ///     is null or empty. </exception>
        /// <exception cref="MailChimpException">
        /// Custom Mail Chimp Exception
        /// </exception>
        public async Task TriggerAsync(int journeyId, int stepId, string emailAddress)
        {
            if (string.IsNullOrEmpty(emailAddress))
            {
                throw new ArgumentException(nameof(emailAddress));
            }
            using (var client = CreateMailClient("customer-journeys/"))
            {
                var response = await client.PostAsJsonAsync($"journeys/{journeyId}/steps/{stepId}/actions/trigger",
                    new { email_address = emailAddress }).ConfigureAwait(false);
                await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
            }
        }
    }
}