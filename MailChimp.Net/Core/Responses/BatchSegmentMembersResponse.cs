using System.Collections.Generic;
using MailChimp.Net.Models;
namespace MailChimp.Net.Core;

/// <summary>
/// The batch segment members response.
/// </summary>
public class BatchSegmentMembersResponse
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BatchSegmentMembers"/> class.
    /// </summary>
    public BatchSegmentMembersResponse()
    {
        MembersAdded = new Member[0];
        MembersRemoved = new Member[0];
    }

    /// <summary>
    /// Members added
    /// </summary>
    [MailChimpJsonProperty("members_added")]
    public Member[] MembersAdded { get; set; }

    /// <summary>
    /// Members removed
    /// </summary>
    [MailChimpJsonProperty("members_removed")]
    public Member[] MembersRemoved { get; set; }

    [MailChimpJsonProperty("total_added")]
    public int TotalAdded { get; set; }

    [MailChimpJsonProperty("total_removed")]
    public int TotalRemoved { get; set; }

    [MailChimpJsonProperty("error_count")]
    public int ErrorCount { get; set; }

    /// <summary>
    /// Gets or sets the links.
    /// </summary>
    [MailChimpJsonProperty("_links")]
    public IEnumerable<Link> Links { get; set; }
}
