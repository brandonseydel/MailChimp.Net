using System.Collections.Generic;
using MailChimp.Net.Core;
namespace MailChimp.Net.Models;

public class ReportingLandingPage
{
    public ReportingLandingPage()
    {
        Links = new HashSet<Link>();
    }

    [MailChimpJsonProperty("id")]
    public string Id { get; set; }

    [MailChimpJsonProperty("name")]
    public string Name { get; set; }

    [MailChimpJsonProperty("title")]
    public string Title { get; set; }

    [MailChimpJsonProperty("status")]
    public string Status { get; set; }

    [MailChimpJsonProperty("list_id")]
    public string ListId { get; set; }

    [MailChimpJsonProperty("visits")]
    public int Visits { get; set; }

    [MailChimpJsonProperty("unique_visits")]
    public int UniqueVisits { get; set; }

    [MailChimpJsonProperty("signup_rate")]
    public double SignupRate { get; set; }

    [MailChimpJsonProperty("clicks")]
    public int Clicks { get; set; }

    [MailChimpJsonProperty("_links")]
    public IEnumerable<Link> Links { get; set; }
}
