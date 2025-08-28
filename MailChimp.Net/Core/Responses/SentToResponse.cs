// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SentToResponse.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;

using MailChimp.Net.Models;

using Newtonsoft.Json;

namespace MailChimp.Net.Core;

/// <summary>
/// The sent to response.
/// </summary>
public class SentToResponse : BaseResponse
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SentToResponse"/> class.
    /// </summary>
    public SentToResponse()
    {
        Recipients = new HashSet<SentTo>();
    }

    /// <summary>
    /// Gets or sets the campaign id.
    /// </summary>
    [JsonProperty("campaign_id")]
    public string CampaignId { get; set; }

    /// <summary>
    /// Gets or sets the recipients.
    /// </summary>
    [JsonProperty("sent_to")]
    public IEnumerable<SentTo> Recipients { get; set; }
}