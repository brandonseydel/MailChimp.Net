using System.Collections.Generic;
using MailChimp.Net.Models;
namespace MailChimp.Net.Core;

public class MemberActivityFeedResponse : BaseResponse
{
    public MemberActivityFeedResponse()
    {
        Activity = new HashSet<MemberActivityFeedItem>();
    }

    [MailChimpJsonProperty("activity")]
    public IEnumerable<MemberActivityFeedItem> Activity { get; set; }

    [MailChimpJsonProperty("email_id")]
    public string EmailId { get; set; }

    [MailChimpJsonProperty("list_id")]
    public string ListId { get; set; }
}
