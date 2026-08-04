using System.Collections.Generic;
using MailChimp.Net.Models;
namespace MailChimp.Net.Core.Responses;

public class BatchListResponse
{
    /// <summary>
    /// An array of objects, each representing a new member that was added to the list.
    /// </summary>
    [MailChimpJsonProperty("new_members")]
    public List<NewMember> NewMembers { get; set; }

    /// <summary>
    /// An array of objects, each representing an existing list member whose subscription status was updated.
    /// </summary>
    [MailChimpJsonProperty("updated_members")]
    public List<NewMember> UpdatedMembers { get; set; }

    /// <summary>
    /// An array of objects, each representing an email address that could not be added to the list
    /// or updated and an error message providing more details.
    /// </summary>
    [MailChimpJsonProperty("errors")]
    public List<ErrorResponse> Errors { get; set; }

    /// <summary>
    /// The total number of items matching the query, irrespective of pagination.
    /// </summary>
    [MailChimpJsonProperty("total_created")]
    public int TotalCreated { get; set; }

    /// <summary>
    /// The total number of items matching the query, irrespective of pagination.
    /// </summary>
    [MailChimpJsonProperty("total_updated")]
    public int TotalUpdated { get; set; }

    /// <summary>
    /// The total number of items matching the query, irrespective of pagination.
    /// </summary>
    [MailChimpJsonProperty("error_count")]
    public int ErrorCount { get; set; }

    /// <summary>
    /// A list of link types and descriptions for the API schema documents.
    /// </summary>
    [MailChimpJsonProperty("_links")]
    public List<Link> Links { get; set; }
}