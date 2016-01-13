using System.Collections.Generic;
using MailChimp.Net.Models;
using Newtonsoft.Json;

namespace MailChimp.Net.Core
{
    public class AuthorizedAppResponse : BaseResponse
    {
        [JsonProperty("apps")]
        public IEnumerable<App> Apps { get; set; }
    }
}