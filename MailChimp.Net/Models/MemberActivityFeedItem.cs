using MailChimp.Net.Core;

namespace MailChimp.Net.Models;

public class MemberActivityFeedItem
{
    [MailChimpJsonProperty("activity_type")]
    public string ActivityType { get; set; }

    [MailChimpJsonProperty("created_at_timestamp")]
    public string CreatedAtTimestamp { get; set; }

    [MailChimpJsonProperty("campaign_id")]
    public string CampaignId { get; set; }

    [MailChimpJsonProperty("campaign_title")]
    public string CampaignTitle { get; set; }

    [MailChimpJsonProperty("link_id")]
    public string LinkId { get; set; }
}
