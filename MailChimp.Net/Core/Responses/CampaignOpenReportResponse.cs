// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CampaignOpen.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;

using MailChimp.Net.Models;

namespace MailChimp.Net.Core;

/// <summary>
/// The campaign open report.
/// </summary>
public class CampaignOpenReportResponse : BaseResponse
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CampaignOpenReportResponse"/> class.
    /// </summary>
    public CampaignOpenReportResponse()
    {
        Members = new HashSet<Open>();
    }

    /// <summary>
    /// Gets or sets the members.
    /// </summary>
    [MailChimpJsonProperty("members")]
    public HashSet<Open> Members { get; set; }

    /// <summary>
    /// Gets or sets the total opens.
    /// </summary>
    [MailChimpJsonProperty("total_opens")]
    public int TotalOpens { get; set; }

    /// <summary>
    /// Gets or sets the campaign id.
    /// </summary>
    [MailChimpJsonProperty("campaign_id")]
    public string CampaignId { get; set; }
}