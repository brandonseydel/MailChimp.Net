using System.Collections.Generic;
using MailChimp.Net.Models;
namespace MailChimp.Net.Core;

public class FacebookAdResponse : BaseResponse
{
    public FacebookAdResponse()
    {
        FacebookAds = new HashSet<FacebookAd>();
    }

    [MailChimpJsonProperty("facebook_ads")]
    public IEnumerable<FacebookAd> FacebookAds { get; set; }
}
