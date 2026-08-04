using System;
using MailChimp.Net.Core;
namespace MailChimp.Net.Models;

/// <summary>
/// Represents a single chimp chatter activity
/// </summary>
public class ChimpChatter
{

    [MailChimpJsonProperty("title")]
    public string Title { get; set; }

    [MailChimpJsonProperty("message")]
    public string Message { get; set; }

    [MailChimpJsonProperty("type")]
		[MailChimpJsonConverter(MailChimpJsonConverterKind.StringEnumDescription)]
    public ChimpChatterType Type { get; set; }

    [MailChimpJsonProperty("update_time")]
    public DateTime UpdateTime { get; set; }

    [MailChimpJsonProperty("url")]
    public string Url { get; set; }

    [MailChimpJsonProperty("list_id")]
    public string ListId { get; set; }

    [MailChimpJsonProperty("campaign_id")]
    public string CampaignId { get; set; }

}
