using MailChimp.Net.Core;
using MailChimp.Net.Interfaces;
using MailChimp.Net.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MailChimp.Net.Logic
{
    public class ListSegmentLogic : BaseLogic, IListSegmentLogic
    {

        private const string BaseUrl = "/lists/{0}/segments";

        public ListSegmentLogic(MailChimpOptions mailChimpConfiguration)
            : base(mailChimpConfiguration)
        {
        }

        public async Task<ListSegment> AddAsync(string listId, Segment segment)
        {
            using (var client = CreateMailClient(string.Format(BaseUrl, listId)))
            {
                var response = await client.PostAsJsonAsync(string.Empty, segment).ConfigureAwait(false);
                await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

                var segmentResponse = await response.Content.ReadAsAsync<ListSegment>().ConfigureAwait(false);
                return segmentResponse;
            }
        }

        public async Task<IEnumerable<ListSegment>> GetAllAsync(string listId, ListSegmentRequest request = null)
        {
            return (await GetResponseAsync(listId, request).ConfigureAwait(false))?.Segments;
        }

        public async Task<ListSegment> GetAsync(string listId, int segmentId)
        {
            using (var client = this.CreateMailClient(string.Format($"{BaseUrl}/", listId)))
            {
                var response = await client.GetAsync($"{segmentId}").ConfigureAwait(false);
                await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

                var segmentResponse = await response.Content.ReadAsAsync<ListSegment>().ConfigureAwait(false);
                return segmentResponse;
            }
        }

        public async Task<ListSegmentResponse> GetResponseAsync(string listId, ListSegmentRequest request = null)
        {
            request = request ?? new ListSegmentRequest
            {
                Limit = _limit
            };

            using (var client = CreateMailClient(string.Format(BaseUrl, listId)))
            {
                var response = await client.GetAsync(request.ToQueryString()).ConfigureAwait(false);
                await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

                var segmentResponse = await response.Content.ReadAsAsync<ListSegmentResponse>().ConfigureAwait(false);
                return segmentResponse;
            }
        }

        public async Task<ListSegment> UpdateAsync(string listId, string segmentId, Segment segment)
        {
            using (var client = CreateMailClient(string.Format(BaseUrl + "/", listId)))
            {
                var response = await client.PatchAsJsonAsync(segmentId, segment).ConfigureAwait(false);
                await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

                var segmentResponse = await response.Content.ReadAsAsync<ListSegment>().ConfigureAwait(false);
                return segmentResponse;
            }
        }

        public async Task<Member> AddMemberAsync(string listId, string segmentId, Member member)
        {
            using (var client = CreateMailClient(string.Format(BaseUrl + "/", listId)))
            {
                var response = await client.PostAsJsonAsync(segmentId + "/members", member).ConfigureAwait(false);
                await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

                var memberResponse = await response.Content.ReadAsAsync<Member>().ConfigureAwait(false);
                return memberResponse;
            }
        }

        public async Task<BatchSegmentMembersResponse> BatchMemberAsync(string listId, string segmentId, BatchSegmentMembers batchSegmentMembers)
        {
            using (var client = CreateMailClient(string.Format(BaseUrl + "/", listId)))
            {
                var response = await client.PostAsJsonAsync(segmentId, batchSegmentMembers).ConfigureAwait(false);
                await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

                var memberResponse = await response.Content.ReadAsAsync<BatchSegmentMembersResponse>().ConfigureAwait(false);
                return memberResponse;
            }
        }

        public async Task DeleteMemberAsync(string listId, string segmentId, string emailAddress)
        {
            using (var client = CreateMailClient(string.Format(BaseUrl + "/", listId)))
            {
                var response = await client.DeleteAsync($"{segmentId}/members/{Hash(emailAddress.ToLower())}").ConfigureAwait(false);
                await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
            }
        }

        public async Task<MemberResponse> GetMemberResponseAsync(string listId, string segmentId, QueryableBaseRequest request = null)
        {
            request = request ?? new QueryableBaseRequest
            {
                Limit = _limit
            };

            using (var client = CreateMailClient(string.Format(BaseUrl + "/", listId)))
            {
                var response = await client.GetAsync(segmentId + "/members" + request.ToQueryString()).ConfigureAwait(false);
                await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

                var memberResponse = await response.Content.ReadAsAsync<MemberResponse>().ConfigureAwait(false);
                return memberResponse;
            }
        }

        public async Task<IEnumerable<Member>> GetAllMembersAsync(string listId, string segmentId, QueryableBaseRequest request = null)
        {
            return (await GetMemberResponseAsync(listId, segmentId, request).ConfigureAwait(false))?.Members;
        }




        public async Task DeleteAsync(string listId, string segmentId)
        {
            using (var client = CreateMailClient(string.Format(BaseUrl + "/", listId)))
            {
                var response = await client.DeleteAsync(segmentId).ConfigureAwait(false);
                await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
            }
        }
    }
}

