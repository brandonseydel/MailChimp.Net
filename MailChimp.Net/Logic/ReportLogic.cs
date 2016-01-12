using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Models;

namespace MailChimp.Net.Logic
{
    internal class ReportLogic : BaseLogic
    {
        public ReportLogic(string apiKey) : base(apiKey)
        {
        }

        public async Task<IEnumerable<Report>> GetAllReportsAsync(ReportRequest request)
        {
            using (var client = CreateMailClient("reports"))
            {
                var response = await client.GetAsync(request.ToQueryString());
                await response.EnsureSuccessMailChimpAsync();
                var reportResponse = await response.Content.ReadAsAsync<ReportResponse>();
                return reportResponse.Reports;
            }
        }

        public async Task<Report> GetReportAsync(BaseRequest request, string campaignId)
        {
            using (var client = CreateMailClient("reports/"))
            {
                var response = await client.GetAsync(campaignId + request.ToQueryString());
                await response.EnsureSuccessMailChimpAsync();

                return await response.Content.ReadAsAsync<Report>();
            }
        }

        public async Task<IEnumerable<Advice>> GetCampaignAdviceAsync(BaseRequest request, string campaignId)
        {
            using (var client = CreateMailClient("reports/"))
            {
                var response = await client.GetAsync($"{campaignId}/advice{request.ToQueryString()}");
                await response.EnsureSuccessMailChimpAsync();

                var campaignAdviceReport = await response.Content.ReadAsAsync<CampaignAdviceReport>();
                return campaignAdviceReport.Advice;
            }
        }

        public async Task<IEnumerable<UrlClicked>> GetClickReportAsync(QueryableBaseRequest request, string campaignId)
        {
            using (var client = CreateMailClient("reports/"))
            {
                var response = await client.GetAsync($"{campaignId}/click-details{request.ToQueryString()}");
                await response.EnsureSuccessMailChimpAsync();

                var clickReportResponse = await response.Content.ReadAsAsync<ClickReportResponse>();
                return clickReportResponse.UrlsClicked;
            }
        }

        public async Task<UrlClicked> GetClickReportDetailsAsync(BaseRequest request, string campaignId, string linkId)
        {
            using (var client = CreateMailClient("reports/"))
            {
                var response = await client.GetAsync($"{campaignId}/click-details/{linkId}{request.ToQueryString()}");
                await response.EnsureSuccessMailChimpAsync();

                return await response.Content.ReadAsAsync<UrlClicked>();
            }
        }

        public async Task<IEnumerable<ClickMember>> GetClickReportMembersAsync(QueryableBaseRequest request, string campaignId, string linkId)
        {
            using (var client = CreateMailClient("reports/"))
            {
                var response = await client.GetAsync($"{campaignId}/click-details/{linkId}/members{request.ToQueryString()}");
                await response.EnsureSuccessMailChimpAsync();

                var clickReportMemberResponse = await response.Content.ReadAsAsync<ClickReportMemberResponse>();
                return clickReportMemberResponse.Members;
            }
        }

        public async Task<ClickMember> GetClickReportMemberAsync(BaseRequest request, string campaignId, string linkId, string emailAddress)
        {
            using (var client = CreateMailClient("reports/"))
            {
                var response = await client.GetAsync($"{campaignId}/click-details/{linkId}/members/{Hash(emailAddress)}{request.ToQueryString()}");
                await response.EnsureSuccessMailChimpAsync();

                return await response.Content.ReadAsAsync<ClickMember>();
            }
        }

        public async Task<IEnumerable<Domain>> GetDomainPerformanceAsync(BaseRequest request, string campaignId)
        {
            using (var client = CreateMailClient("reports/"))
            {
                var response = await client.GetAsync($"{campaignId}/domain-performance{request.ToQueryString()}");
                await response.EnsureSuccessMailChimpAsync();

                var clickReportMemberResponse = await response.Content.ReadAsAsync<DomainPerformanceResponse>();
                return clickReportMemberResponse.Domains;
            }
        }

        public async Task GetEepUrlReportAsync(BaseRequest request, string campaignId)
        {
        }

        public async Task GetEmailActivitiesAsync(QueryableBaseRequest request, string campaignId)
        {
        }

        public async Task GetEmailActivityAsync(BaseRequest request, string campaignId, string emailAddress)
        {
        }

        public async Task GetLocationsAsync(BaseRequest request, string campaignId)
        {
        }

        public async Task GetSentToRecipientsAsync(QueryableBaseRequest request, string campaignId)
        {
        }

        public async Task GetSentToRecipientAsync(BaseRequest request, string campaignId)
        {
        }

        public async Task GetSubReportAsync(BaseRequest request, string campaignId)
        {
        }

        public async Task GetUnsubscribesAsync(QueryableBaseRequest request, string campaignId)
        {
        }

        public async Task GetUnsubscriberAsync(BaseRequest request, string campaignId, string emailAddress)
        {
        }
    }
}