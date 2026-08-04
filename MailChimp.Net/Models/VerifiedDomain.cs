using System.Collections.Generic;
using MailChimp.Net.Core;
namespace MailChimp.Net.Models;

public class VerifiedDomain
{
    public VerifiedDomain()
    {
        Links = new HashSet<Link>();
    }

    [MailChimpJsonProperty("domain")]
    public string Domain { get; set; }

    [MailChimpJsonProperty("verified")]
    public bool Verified { get; set; }

    [MailChimpJsonProperty("authenticated")]
    public bool Authenticated { get; set; }

    [MailChimpJsonProperty("verification_email")]
    public string VerificationEmail { get; set; }

    [MailChimpJsonProperty("verification_code")]
    public string VerificationCode { get; set; }

    [MailChimpJsonProperty("_links")]
    public IEnumerable<Link> Links { get; set; }
}
