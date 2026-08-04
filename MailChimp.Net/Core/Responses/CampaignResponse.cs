// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CampaignResponse.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;

using MailChimp.Net.Models;

namespace MailChimp.Net.Core;

/// <summary>
/// The campaign response.
/// </summary>
public class CampaignResponse : BaseResponse
{
    /// <summary>
    /// Gets or sets the campaigns.
    /// </summary>
    [MailChimpJsonProperty("campaigns")]
    public IEnumerable<Campaign> Campaigns { get; set; }
}