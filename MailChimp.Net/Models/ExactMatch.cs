using System.Collections.Generic;

using MailChimp.Net.Core;
namespace MailChimp.Net.Models;

public class ExactMatch
{
    public ExactMatch()
    {
        Members = new HashSet<Member>();
    }

    [MailChimpJsonProperty("members")]
    public IEnumerable<Member> Members { get; set; }

    [MailChimpJsonProperty("total_items")]
    public int TotalItems { get; set; }
}
