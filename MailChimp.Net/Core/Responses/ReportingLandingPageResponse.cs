using System.Collections.Generic;
using MailChimp.Net.Models;
namespace MailChimp.Net.Core;

public class ReportingLandingPageResponse : BaseResponse
{
    public ReportingLandingPageResponse()
    {
        LandingPages = new HashSet<ReportingLandingPage>();
    }

    [MailChimpJsonProperty("landing_pages")]
    public IEnumerable<ReportingLandingPage> LandingPages { get; set; }
}
