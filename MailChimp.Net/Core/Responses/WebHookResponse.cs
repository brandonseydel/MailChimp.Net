using System.Collections.Generic;
using MailChimp.Net.Models;
namespace MailChimp.Net.Core;

public class WebHookResponse : BaseResponse
{

    public WebHookResponse()
    {
        Webhooks = new HashSet<WebHook>();
    }

    [MailChimpJsonProperty("webhooks")]
    public IEnumerable<WebHook> Webhooks { get; set; }

    [MailChimpJsonProperty("list_id")]
    public string ListId { get; set; }
}

