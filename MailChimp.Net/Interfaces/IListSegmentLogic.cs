using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Models;

namespace MailChimp.Net.Interfaces
{
    public interface IListSegmentLogic
    {
        Task<ListSegment> AddAsync(string listId, Segment segment, CancellationToken cancellationToken = default);
        Task<IEnumerable<ListSegment>> GetAllAsync(string listId, ListSegmentRequest request = null, CancellationToken cancellationToken = default);
        Task<ListSegment> GetAsync(string listId, int segmentId, CancellationToken cancellationToken = default);
        Task<ListSegmentResponse> GetResponseAsync(string listId, ListSegmentRequest request = null, CancellationToken cancellationToken = default  );
        Task<ListSegment> UpdateAsync(string listId, string segmentId, Segment segment, CancellationToken cancellationToken = default);
        Task<Member> AddMemberAsync(string listId, string segmentId, Member member, CancellationToken cancellationToken = default);
        Task<ListSegment> ClearMembersAsync(string listId, string segmentId, CancellationToken cancellationToken = default);
        Task DeleteMemberAsync(string listId, string segmentId, string emailAddressOrHash, CancellationToken cancellationToken = default);
        Task<MemberResponse> GetMemberResponseAsync(string listId, string segmentId, QueryableBaseRequest request = null, CancellationToken cancellationToken = default);
        Task<IEnumerable<Member>> GetAllMembersAsync(string listId, string segmentId, QueryableBaseRequest request = null, CancellationToken cancellationToken = default);
        Task<BatchSegmentMembersResponse> BatchMemberAsync(string listId, string segmentId, BatchSegmentMembers batchSegmentMembers, CancellationToken cancellationToken = default);
        Task DeleteAsync(string listId, string segmentId, CancellationToken cancellationToken = default);
    }
}
