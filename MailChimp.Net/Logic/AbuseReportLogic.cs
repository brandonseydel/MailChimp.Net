using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Interfaces;
using MailChimp.Net.Models;

namespace MailChimp.Net.Logic
{
    public class AbuseReportLogic : BaseLogic, IAbuseReportLogic
    {
        public AbuseReportLogic(string apiKey) : base(apiKey)
        {
        }

        public async Task<IEnumerable<AbuseReport>> GetAllAsync(string listId, QueryableBaseRequest request)
        {
            using (var client = CreateMailClient("lists/"))
            {
                var response = await client.GetAsync($"{listId}/abuse-reports{request.ToQueryString()}");
                await response.EnsureSuccessMailChimpAsync();

                var appResponse = await response.Content.ReadAsAsync<AbuseReportResponse>();
                return appResponse.AbuseReports;
            }
        }

        public async Task<AbuseReport> GetAsync(string listId, string reportId, QueryableBaseRequest request)
        {
            using (var client = CreateMailClient("lists/"))
            {
                var response = await client.GetAsync($"{listId}/abuse-reports{reportId}{request.ToQueryString()}");
                await response.EnsureSuccessMailChimpAsync();

                return await response.Content.ReadAsAsync<AbuseReport>();
            }
        }
    }
}