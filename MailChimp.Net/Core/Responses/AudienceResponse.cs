using System.Collections.Generic;
using MailChimp.Net.Models;
namespace MailChimp.Net.Core;

public class AudienceResponse : BaseResponse
{
    public AudienceResponse()
    {
        Audiences = new HashSet<Audience>();
    }

    [MailChimpJsonProperty("audiences")]
    public IEnumerable<Audience> Audiences { get; set; }
}
