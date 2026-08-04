// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MergeFieldResponse.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;

using MailChimp.Net.Models;

namespace MailChimp.Net.Core;

/// <summary>
/// The merge field response.
/// </summary>
public class MergeFieldResponse : BaseResponse
{
    /// <summary>
    /// Initializes a new instance of the <see cref="MergeFieldResponse"/> class.
    /// </summary>
    public MergeFieldResponse()
    {
        MergeFields = new HashSet<MergeField>();
    }

    /// <summary>
    /// Gets or sets the list id.
    /// </summary>
    [MailChimpJsonProperty("list_id")]
    public string ListId { get; set; }

    /// <summary>
    /// Gets or sets the merge fields.
    /// </summary>
    [MailChimpJsonProperty("merge_fields")]
    public IEnumerable<MergeField> MergeFields { get; set; }
}