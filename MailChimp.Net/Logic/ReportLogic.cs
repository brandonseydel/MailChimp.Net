using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Interfaces;
using MailChimp.Net.Models;

namespace MailChimp.Net.Logic
{
    internal class ReportLogic : BaseLogic, IReportLogic
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

        public async Task<IEnumerable<ClickMember>> GetClickReportMembersAsync(QueryableBaseRequest request,
            string campaignId, string linkId)
        {
            using (var client = CreateMailClient("reports/"))
            {
                var response =
                    await client.GetAsync($"{campaignId}/click-details/{linkId}/members{request.ToQueryString()}");
                await response.EnsureSuccessMailChimpAsync();

                var clickReportMemberResponse = await response.Content.ReadAsAsync<ClickReportMemberResponse>();
                return clickReportMemberResponse.Members;
            }
        }

        public async Task<ClickMember> GetClickReportMemberAsync(BaseRequest request, string campaignId, string linkId,
            string emailAddress)
        {
            using (var client = CreateMailClient("reports/"))
            {
                var response =
                    await
                        client.GetAsync(
                            $"{campaignId}/click-details/{linkId}/members/{Hash(emailAddress)}{request.ToQueryString()}");
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

                var domainPerformanceResponse = await response.Content.ReadAsAsync<DomainPerformanceResponse>();
                return domainPerformanceResponse.Domains;
            }
        }

        public async Task<EepUrlActivity> GetEepUrlReportAsync(BaseRequest request, string campaignId)
        {
            using (var client = CreateMailClient("reports/"))
            {
                var response = await client.GetAsync($"{campaignId}/click-details/eepurl{request.ToQueryString()}");
                await response.EnsureSuccessMailChimpAsync();

                return await response.Content.ReadAsAsync<EepUrlActivity>();
            }
        }

        public async Task<IEnumerable<EmailActivity>> GetEmailActivitiesAsync(QueryableBaseRequest request,
            string campaignId)
        {
            using (var client = CreateMailClient("reports/"))
            {
                var response = await client.GetAsync($"{campaignId}/email-activity{request.ToQueryString()}");
                await response.EnsureSuccessMailChimpAsync();

                var emailActivityResponse = await response.Content.ReadAsAsync<EmailResponse>();
                return emailActivityResponse.EmailActivities;
            }
        }

        public async Task<EmailActivity> GetEmailActivityAsync(BaseRequest request, string campaignId,
            string emailAddress)
        {
            using (var client = CreateMailClient("reports/"))
            {
                var response =
                    await client.GetAsync($"{campaignId}/email-activity/{Hash(emailAddress)}{request.ToQueryString()}");
                await response.EnsureSuccessMailChimpAsync();

                return await response.Content.ReadAsAsync<EmailActivity>();
            }
        }

        public async Task<IEnumerable<OpenLocation>> GetLocationsAsync(BaseRequest request, string campaignId)
        {
            using (var client = CreateMailClient("reports/"))
            {
                var response = await client.GetAsync($"{campaignId}/locations{request.ToQueryString()}");
                await response.EnsureSuccessMailChimpAsync();

                var openLocationResponse = await response.Content.ReadAsAsync<OpenLocationResponse>();
                return openLocationResponse.Locations;
            }
        }

        public async Task<IEnumerable<SentTo>> GetSentToRecipientsAsync(QueryableBaseRequest request, string campaignId)
        {
            using (var client = CreateMailClient("reports/"))
            {
                var response = await client.GetAsync($"{campaignId}/sent-to{request.ToQueryString()}");
                await response.EnsureSuccessMailChimpAsync();

                var sendToResponse = await response.Content.ReadAsAsync<SentToResponse>();
                return sendToResponse.Recipients;
            }
        }

        public async Task<SentTo> GetSentToRecipientAsync(QueryableBaseRequest request, string campaignId,
            string emailAddress)
        {
            using (var client = CreateMailClient("reports/"))
            {
                var response =
                    await client.GetAsync($"{campaignId}/sent-to/{Hash(emailAddress)}{request.ToQueryString()}");
                await response.EnsureSuccessMailChimpAsync();

                return await response.Content.ReadAsAsync<SentTo>();
            }
        }

        public async Task<IEnumerable<Report>> GetSubReportAsync(BaseRequest request, string campaignId)
        {
            using (var client = CreateMailClient("reports"))
            {
                var response = await client.GetAsync($"{campaignId}/sub-reports{request.ToQueryString()}");
                await response.EnsureSuccessMailChimpAsync();
                var reportResponse = await response.Content.ReadAsAsync<ReportResponse>();
                return reportResponse.Reports;
            }
        }

        public async Task<IEnumerable<Unsubscribe>> GetUnsubscribesAsync(QueryableBaseRequest request, string campaignId)
        {
            using (var client = CreateMailClient("reports"))
            {
                var response = await client.GetAsync($"{campaignId}/unsubscribed{request.ToQueryString()}");
                await response.EnsureSuccessMailChimpAsync();
                var reportResponse = await response.Content.ReadAsAsync<UnsubscribeReportResponse>();
                return reportResponse.Unsubscribes;
            }
        }

        public async Task<Unsubscribe> GetUnsubscriberAsync(BaseRequest request, string campaignId, string emailAddress)
        {
            using (var client = CreateMailClient("reports"))
            {
                var response =
                    await client.GetAsync($"{campaignId}/unsubscribed/{Hash(emailAddress)}{request.ToQueryString()}");
                await response.EnsureSuccessMailChimpAsync();
                return await response.Content.ReadAsAsync<Unsubscribe>();
            }
        }
    }
}