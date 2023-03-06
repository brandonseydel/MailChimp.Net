// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CampaignAdvice.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;

using MailChimp.Net.Models;

using Newtonsoft.Json;

namespace MailChimp.Net.Core;

/// <summary>
/// The campaign advice report.
/// </summary>
public class CampaignAdviceReport : BaseResponse
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CampaignAdviceReport"/> class.
    /// </summary>
    public CampaignAdviceReport()
    {
        Advice = new HashSet<Advice>();
    }

    /// <summary>
    /// Gets or sets the advice.
    /// </summary>
    [JsonProperty("advice")]
    public IEnumerable<Advice> Advice { get; set; }

    /// <summary>
    /// Gets or sets the campaign id.
    /// </summary>
    [JsonProperty("campaign_id")]
    public string CampaignId { get; set; }
}