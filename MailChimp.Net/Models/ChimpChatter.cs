using System;
using MailChimp.Net.Core;
using Newtonsoft.Json;

namespace MailChimp.Net.Models;

/// <summary>
/// Represents a single chimp chatter activity
/// </summary>
public class ChimpChatter
{

    [JsonProperty("title")]
    public string Title { get; set; }

    [JsonProperty("message")]
    public string Message { get; set; }

    [JsonProperty("type")]
		[JsonConverter(typeof(StringEnumDescriptionConverter))]
    public ChimpChatterType Type { get; set; }

    [JsonProperty("update_time")]
    public DateTime UpdateTime { get; set; }

    [JsonProperty("url")]
    public string Url { get; set; }

    [JsonProperty("list_id")]
    public string ListId { get; set; }

    [JsonProperty("campaign_id")]
    public string CampaignId { get; set; }

}
