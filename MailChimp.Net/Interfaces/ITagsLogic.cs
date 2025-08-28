using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Models;

namespace MailChimp.Net.Interfaces;

public interface ITagsLogic
{
    Task<IEnumerable<ListTag>> GetAllAsync(string listId, TagsRequest request = null, CancellationToken cancellationToken = default);
    Task<ListTagsResponse> GetResponseAsync(string listId, TagsRequest request = null, CancellationToken cancellationToken = default);
}
