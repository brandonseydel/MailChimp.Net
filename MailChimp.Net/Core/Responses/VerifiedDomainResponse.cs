using System.Collections.Generic;
using MailChimp.Net.Models;
namespace MailChimp.Net.Core;

public class VerifiedDomainResponse : BaseResponse
{
    public VerifiedDomainResponse()
    {
        Domains = new HashSet<VerifiedDomain>();
    }

    [MailChimpJsonProperty("domains")]
    public IEnumerable<VerifiedDomain> Domains { get; set; }
}
