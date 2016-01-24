using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Interfaces;
using MailChimp.Net.Models;

namespace MailChimp.Net.Logic
{
    public class ActivityLogic : BaseLogic, IActivityLogic
    {
        public ActivityLogic(string apiKey) : base(apiKey)
        {
        }

        public async Task<IEnumerable<Activity>> GetAllAsync(string listId, BaseRequest request)
        {
            using (var client = CreateMailClient("lists/"))
            {
                var response = await client.GetAsync($"{listId}/activity{request.ToQueryString()}");
                await response.EnsureSuccessMailChimpAsync();

                var appResponse = await response.Content.ReadAsAsync<ActivityResponse>();
                return appResponse.Activities;
            }
        }
    }
}