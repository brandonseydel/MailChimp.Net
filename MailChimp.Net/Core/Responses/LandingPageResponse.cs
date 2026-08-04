using System.Collections.Generic;
using MailChimp.Net.Models;
namespace MailChimp.Net.Core;

public class LandingPageResponse : BaseResponse
{
    public LandingPageResponse()
    {
        LandingPages = new HashSet<LandingPage>();
    }

    [MailChimpJsonProperty("landing_pages")]
    public IEnumerable<LandingPage> LandingPages { get; set; }
}
