using System.Collections.Generic;
using MailChimp.Net.Models;
namespace MailChimp.Net.Core;

public class AudienceContactResponse : BaseResponse
{
    public AudienceContactResponse()
    {
        Contacts = new HashSet<AudienceContact>();
    }

    [MailChimpJsonProperty("contacts")]
    public IEnumerable<AudienceContact> Contacts { get; set; }

    [MailChimpJsonProperty("audience_id")]
    public string AudienceId { get; set; }
}
