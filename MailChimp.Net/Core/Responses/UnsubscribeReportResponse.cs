// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UnsubscribeReportResponse.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;

using MailChimp.Net.Models;

namespace MailChimp.Net.Core;

/// <summary>
/// The unsubscribe report response.
/// </summary>
public class UnsubscribeReportResponse : BaseResponse
{
    /// <summary>
    /// Initializes a new instance of the <see cref="UnsubscribeReportResponse"/> class.
    /// </summary>
    public UnsubscribeReportResponse()
    {
        Unsubscribes = new HashSet<Unsubscribe>();
    }

    /// <summary>
    /// Gets or sets the campaign id.
    /// </summary>
    [MailChimpJsonProperty("campaign_id")]
    public string CampaignId { get; set; }

    /// <summary>
    /// Gets or sets the unsubscribes.
    /// </summary>
    [MailChimpJsonProperty("unsubscribes")]
    public IEnumerable<Unsubscribe> Unsubscribes { get; set; }
}