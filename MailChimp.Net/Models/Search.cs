using System.Collections.Generic;

using MailChimp.Net.Core;
namespace MailChimp.Net.Models;

public class CampaignSearchResult
{
    public CampaignSearchResult()
    {
        Results = new List<Result>();
        Links = new List<Link>();
    }

    [MailChimpJsonProperty("results")]
    public IEnumerable<Result> Results { get; set; }

    [MailChimpJsonProperty("total_items")]
    public int TotalItems { get; set; }

    [MailChimpJsonProperty("_links")]
    public IEnumerable<Link> Links { get; set; }
}
