// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SegmentOpts.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;
using MailChimp.Net.Core;
namespace MailChimp.Net.Models;

/// <summary>
/// The segment opts.
/// </summary>
public class SegmentOptions
{

    public SegmentOptions()
    {
        Conditions = new HashSet<Condition>();
    }

    /// <summary>
    /// Gets or sets the conditions.
    /// </summary>
    [MailChimpJsonProperty("conditions")]
    public IEnumerable<Condition> Conditions { get; set; }

    /// <summary>
    /// Gets or sets the match.
    /// </summary>
    /// <see cref="Models.Match"/>
    [MailChimpJsonProperty("match")]
		[MailChimpJsonConverter(MailChimpJsonConverterKind.StringEnumDescription)]
    public Match Match { get; set; }

    /// <summary>
    /// Gets or sets the saved segment id.
    /// </summary>
    [MailChimpJsonProperty("saved_segment_id")]
    public int SavedSegmentId { get; set; }
}