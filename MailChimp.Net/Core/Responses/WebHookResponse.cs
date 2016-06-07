using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace MailChimp.Net.Core
{
    public class WebHookResponse : BaseResponse
    {

        public WebHookResponse()
        {
            this.Webhooks = new HashSet<WebHook>();
        }

        [JsonProperty("webhooks")]
        public IEnumerable<WebHook> Webhooks { get; set; }

        [JsonProperty("list_id")]
        public string ListId { get; set; }
    }
}

