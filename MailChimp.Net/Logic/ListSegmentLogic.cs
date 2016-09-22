using System.Collections.Generic;
using static System.Net.Http.HttpContentExtensions;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Interfaces;
using MailChimp.Net.Models;

namespace MailChimp.Net.Logic
{
    public class ListSegmentLogic : BaseLogic, IListSegmentLogic
    {

        private const string BaseUrl = "/lists/{0}/segments";


        public ListSegmentLogic(string apiKey) : base(apiKey)
        {
        }

        public async Task<ListSegment> AddAsync(string listId, Segment segment)
        {
            using (var client = this.CreateMailClient(string.Format(BaseUrl, listId)))
            {
                var response = await client.PostAsJsonAsync(string.Empty, segment).ConfigureAwait(false);
                await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

                var segmentResponse = await response.Content.ReadAsAsync<ListSegment>().ConfigureAwait(false);
                return segmentResponse;
            }
        }

        public async Task<IEnumerable<ListSegment>> GetAllAsync(string listId, ListSegmentRequest request = null)
        {
            var response = await this.GetResponseAsync(listId, request);
            return response.Segments;
        }

        public async Task<ListSegmentResponse> GetResponseAsync(string listId, ListSegmentRequest request = null)
        {
            using (var client = this.CreateMailClient(string.Format(BaseUrl, listId)))
            {
                var response = await client.GetAsync(request?.ToQueryString()).ConfigureAwait(false);
                await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

                var segmentResponse = await response.Content.ReadAsAsync<ListSegmentResponse>().ConfigureAwait(false);
                return segmentResponse;
            }
        }

        public async Task<ListSegment> UpdateAsync(string listId, string segmentId, Segment segment)
        {
            using (var client = this.CreateMailClient(string.Format(BaseUrl + "/", listId)))
            {
                var response = await client.PatchAsJsonAsync(segmentId, segment).ConfigureAwait(false);
                await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

                var segmentResponse = await response.Content.ReadAsAsync<ListSegment>().ConfigureAwait(false);
                return segmentResponse;
            }
        }

        public async Task<Member> AddMemberAsync(string listId, string segmentId, Member member)
        {
            using (var client = this.CreateMailClient(string.Format(BaseUrl + "/", listId)))
            {
                var response = await client.PostAsJsonAsync(segmentId + "/members", member).ConfigureAwait(false);
                await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

                var memberResponse = await response.Content.ReadAsAsync<Member>().ConfigureAwait(false);
                return memberResponse;
            }
        }

        public async Task DeleteMemberAsync(string listId, string segmentId, string emailAddress)
        {
            using (var client = this.CreateMailClient(string.Format(BaseUrl + "/", listId)))
            {
                var response = await client.DeleteAsync($"{segmentId}/members/{this.Hash(emailAddress.ToLower())}").ConfigureAwait(false);
                await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
            }
        }

        public async Task<MemberResponse> GetMemberResponseAsync(string listId, string segmentId, QueryableBaseRequest request = null)
        {
            request = request ?? new QueryableBaseRequest
            {
                Limit = MailChimpManager.Limit
            };

            using (var client = this.CreateMailClient(string.Format(BaseUrl + "/", listId)))
            {
                var response = await client.GetAsync(segmentId + "/members" + request?.ToQueryString()).ConfigureAwait(false);
                await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

                var memberResponse = await response.Content.ReadAsAsync<MemberResponse>().ConfigureAwait(false);
                return memberResponse;
            }
        }

        public async Task<IEnumerable<Member>> GetAllMembersAsync(string listId, string segmentId, QueryableBaseRequest request = null)
        {
            var response = await GetMemberResponseAsync(listId, segmentId, request);
            return response.Members;
        }




        public async Task DeleteAsync(string listId, string segmentId)
        {
            using (var client = this.CreateMailClient(string.Format(BaseUrl + "/", listId)))
            {
                var response = await client.DeleteAsync(segmentId).ConfigureAwait(false);
                await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
            }
        }
    }
}

