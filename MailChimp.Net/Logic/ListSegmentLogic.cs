using MailChimp.Net.Core;
using MailChimp.Net.Interfaces;
using MailChimp.Net.Models;
using System.Collections.Generic;
using System.Threading;
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

        public async Task<ListSegment> AddAsync(string listId, Segment segment, CancellationToken cancellationToken = default)
        {
            using var client = CreateMailClient(string.Format(BaseUrl, listId));
            var response = await client.PostAsJsonAsync(string.Empty, segment, cancellationToken).ConfigureAwait(false);
            await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

            var segmentResponse = await response.Content.ReadAsAsync<ListSegment>().ConfigureAwait(false);
            return segmentResponse;
        }

        public async Task<IEnumerable<ListSegment>> GetAllAsync(string listId, ListSegmentRequest request = null, CancellationToken cancellationToken = default) => (await GetResponseAsync(listId, request).ConfigureAwait(false))?.Segments;

        public async Task<ListSegment> GetAsync(string listId, int segmentId, CancellationToken cancellationToken = default)
        {
            using var client = this.CreateMailClient(string.Format($"{BaseUrl}/", listId));
            var response = await client.GetAsync($"{segmentId}", cancellationToken).ConfigureAwait(false);
            await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

            var segmentResponse = await response.Content.ReadAsAsync<ListSegment>().ConfigureAwait(false);
            return segmentResponse;
        }

        public async Task<ListSegmentResponse> GetResponseAsync(string listId, ListSegmentRequest request = null, CancellationToken cancellationToken = default)
        {
            request ??= new ListSegmentRequest
            {
                Limit = _limit
            };

            using var client = CreateMailClient(string.Format(BaseUrl, listId));
            var response = await client.GetAsync(request.ToQueryString(), cancellationToken).ConfigureAwait(false);
            await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

            var segmentResponse = await response.Content.ReadAsAsync<ListSegmentResponse>().ConfigureAwait(false);
            return segmentResponse;
        }

        public async Task<ListSegment> UpdateAsync(string listId, string segmentId, Segment segment, CancellationToken cancellationToken = default)
        {
            using var client = CreateMailClient(string.Format(BaseUrl + "/", listId));
            var response = await client.PatchAsJsonAsync(segmentId, segment, cancellationToken).ConfigureAwait(false);
            await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

            var segmentResponse = await response.Content.ReadAsAsync<ListSegment>().ConfigureAwait(false);
            return segmentResponse;
        }

        public async Task<Member> AddMemberAsync(string listId, string segmentId, Member member, CancellationToken cancellationToken = default)
        {
            using var client = CreateMailClient(string.Format(BaseUrl + "/", listId));
            var response = await client.PostAsJsonAsync(segmentId + "/members", member, cancellationToken).ConfigureAwait(false);
            await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

            var memberResponse = await response.Content.ReadAsAsync<Member>().ConfigureAwait(false);
            return memberResponse;
        }

        public async Task<BatchSegmentMembersResponse> BatchMemberAsync(string listId, string segmentId, BatchSegmentMembers batchSegmentMembers, CancellationToken cancellationToken = default)
        {
            using var client = CreateMailClient(string.Format(BaseUrl + "/", listId));
            var response = await client.PostAsJsonAsync(segmentId, batchSegmentMembers, cancellationToken).ConfigureAwait(false);
            await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

            var memberResponse = await response.Content.ReadAsAsync<BatchSegmentMembersResponse>().ConfigureAwait(false);
            return memberResponse;
        }

        public async Task<ListSegment> ClearMembersAsync(string listId, string segmentId, CancellationToken cancellationToken = default)
        {
            using var client = CreateMailClient(string.Format(BaseUrl + "/", listId));
            var request = new { static_segment = new object[] { } };
            var response = await client.PatchAsJsonAsync(segmentId, request, cancellationToken).ConfigureAwait(false);
            await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

            var segmentResponse = await response.Content.ReadAsAsync<ListSegment>().ConfigureAwait(false);
            return segmentResponse;
        }

        public async Task DeleteMemberAsync(string listId, string segmentId, string emailAddress, CancellationToken cancellationToken = default)
        {
            using var client = CreateMailClient(string.Format(BaseUrl + "/", listId));
            var response = await client.DeleteAsync($"{segmentId}/members/{Hash(emailAddress.ToLower())}", cancellationToken).ConfigureAwait(false);
            await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
        }

        public async Task<MemberResponse> GetMemberResponseAsync(string listId, string segmentId, QueryableBaseRequest request = null, CancellationToken cancellationToken = default)
        {
            request ??= new QueryableBaseRequest
            {
                Limit = _limit
            };

            using var client = CreateMailClient(string.Format(BaseUrl + "/", listId));
            var response = await client.GetAsync(segmentId + "/members" + request.ToQueryString(), cancellationToken).ConfigureAwait(false);
            await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

            var memberResponse = await response.Content.ReadAsAsync<MemberResponse>().ConfigureAwait(false);
            return memberResponse;
        }

        public async Task<IEnumerable<Member>> GetAllMembersAsync(string listId, string segmentId, QueryableBaseRequest request = null, CancellationToken cancellationToken = default) => (await GetMemberResponseAsync(listId, segmentId, request).ConfigureAwait(false))?.Members;




        public async Task DeleteAsync(string listId, string segmentId, CancellationToken cancellationToken = default)
        {
            using var client = CreateMailClient(string.Format(BaseUrl + "/", listId));
            var response = await client.DeleteAsync(segmentId, cancellationToken).ConfigureAwait(false);
            await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
        }
    }
}

