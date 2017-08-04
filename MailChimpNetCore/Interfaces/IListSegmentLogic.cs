﻿using System.Collections.Generic;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Models;

namespace MailChimp.Net.Interfaces
{
    public interface IListSegmentLogic
    {
        Task<ListSegment> AddAsync(string listId, Segment segment);
        Task<IEnumerable<ListSegment>> GetAllAsync(string listId, ListSegmentRequest request = null);
        Task<ListSegment> GetAsync(string listId, int segmentId);
        Task<ListSegmentResponse> GetResponseAsync(string listId, ListSegmentRequest request = null);
        Task<ListSegment> UpdateAsync(string listId, string segmentId, Segment segment);
        Task<Member> AddMemberAsync(string listId, string segmentId, Member member);
        Task DeleteMemberAsync(string listId, string segmentId, string emailAddress);
        Task<MemberResponse> GetMemberResponseAsync(string listId, string segmentId, QueryableBaseRequest request = null);
        Task<IEnumerable<Member>> GetAllMembersAsync(string listId, string segmentId, QueryableBaseRequest request = null);
        Task DeleteAsync(string listId, string segmentId);
    }
}
