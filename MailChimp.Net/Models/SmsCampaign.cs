using System.Collections.Generic;
using MailChimp.Net.Core;
namespace MailChimp.Net.Models;

public class SmsCampaign
{
    public SmsCampaign()
    {
        Links = new HashSet<Link>();
    }

    [MailChimpJsonProperty("id")]
    public string Id { get; set; }

    [MailChimpJsonProperty("name")]
    public string Name { get; set; }

    [MailChimpJsonProperty("status")]
    public string Status { get; set; }

    [MailChimpJsonProperty("list_id")]
    public string ListId { get; set; }

    [MailChimpJsonProperty("created_at")]
    public string CreatedAt { get; set; }

    [MailChimpJsonProperty("send_time")]
    public string SendTime { get; set; }

    [MailChimpJsonProperty("scheduled_time")]
    public string ScheduledTime { get; set; }

    [MailChimpJsonProperty("_links")]
    public IEnumerable<Link> Links { get; set; }
}
