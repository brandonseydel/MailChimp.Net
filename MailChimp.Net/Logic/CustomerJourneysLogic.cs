using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Interfaces;

namespace MailChimp.Net.Logic
{
    public class CustomerJourneysLogic : BaseLogic, ICustomerJourneysLogic
    {
        /// <summary>
        /// The base url.
        /// </summary>
        private string BaseUrl = "customer-journeys";


        public CustomerJourneysLogic(MailChimpOptions mailChimpConfiguration)
            : base(mailChimpConfiguration)
        {
        }

        public async Task TriggerAsync(int journeyId, int stepId, string emailAddress)
        {
            using (var client = CreateMailClient(BaseUrl))
            {
                var response = await client.PostAsJsonAsync($"/journeys/{journeyId}/steps/{stepId}/actions/trigger",
                    new { email_address = emailAddress }).ConfigureAwait(false);
                await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
            }
        }
    }
}