using System.Collections.Generic;
using MailChimp.Net.Models;
using Newtonsoft.Json;

namespace MailChimp.Net.Core
{
    public class WebHookResponse : BaseResponse
    {

        public WebHookResponse()
        {
            Webhooks = new HashSet<WebHook>();
        }

        [JsonProperty("webhooks")]
        public IEnumerable<WebHook> Webhooks { get; set; }

        [JsonProperty("list_id")]
        public string ListId { get; set; }
    }
}

