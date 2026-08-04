using System.Collections.Generic;
using MailChimp.Net.Core;
namespace MailChimp.Net.Models;

public class Audience
{
    public Audience()
    {
        Links = new HashSet<Link>();
    }

    [MailChimpJsonProperty("id")]
    public string Id { get; set; }

    [MailChimpJsonProperty("name")]
    public string Name { get; set; }

    [MailChimpJsonProperty("permission_reminder")]
    public string PermissionReminder { get; set; }

    [MailChimpJsonProperty("contact")]
    public Contact Contact { get; set; }

    [MailChimpJsonProperty("campaign_defaults")]
    public CampaignDefaults CampaignDefaults { get; set; }

    [MailChimpJsonProperty("date_created")]
    public string DateCreated { get; set; }

    [MailChimpJsonProperty("list_rating")]
    public int ListRating { get; set; }

    [MailChimpJsonProperty("_links")]
    public IEnumerable<Link> Links { get; set; }
}
