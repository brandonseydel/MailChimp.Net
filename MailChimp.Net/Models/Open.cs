// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Open.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using Newtonsoft.Json;

using System;
using System.Collections.Generic;

namespace MailChimp.Net.Models;

/// <summary>
/// The Open.
/// </summary>
public class Open
{
    /// <summary>
    /// Gets or sets the campaign id.
    /// </summary>
    [JsonProperty("campaign_id")]
    public string CampaignId { get; set; }

    /// <summary>
    /// Gets or sets the list id.
    /// </summary>
    [JsonProperty("list_id")]
    public string ListId { get; set; }

    /// <summary>
    /// Gets or sets the email id.
    /// </summary>
    [JsonProperty("email_id")]
    public string EmailId { get; set; }

    /// <summary>
    /// Gets or sets the email address.
    /// </summary>
    [JsonProperty("email_address")]
    public string EmailAddress { get; set; }

    /// <summary>
    /// Gets or sets the merge fields.
    /// </summary>
    [JsonProperty("merge_fields")]
    public Dictionary<string, object> MergeFields { get; set; }

    /// <summary>
    /// Gets or sets the vip.
    /// </summary>
    [JsonProperty("vip")]
    public bool VIP { get; set; }

    /// <summary>
    /// Gets or sets the clicks.
    /// </summary>
    [JsonProperty("opens_count")]
    public int OpensCount { get; set; }

    /// <summary>
    /// Gets or sets the clicks.
    /// </summary>
    [JsonProperty("opens")]
    public TimeStamp[] Opens  { get; set; }

    /// <summary>
    /// Gets or sets the links.
    /// </summary>
    [JsonProperty("_links")]
    public IEnumerable<Link> Links { get; set; }

}