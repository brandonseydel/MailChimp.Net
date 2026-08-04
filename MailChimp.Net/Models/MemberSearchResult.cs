using System.Collections.Generic;

using MailChimp.Net.Core;
namespace MailChimp.Net.Models;


public class MemberSearchResult
{
    public MemberSearchResult()
    {
        Links = new HashSet<Link>();
    }

    [MailChimpJsonProperty("exact_matches")]
    public ExactMatch ExactMatch { get; set; }

    [MailChimpJsonProperty("full_search")]
    public FullSearch FullSearch { get; set; }

    [MailChimpJsonProperty("_links")]
    public IEnumerable<Link> Links { get; set; }
}
