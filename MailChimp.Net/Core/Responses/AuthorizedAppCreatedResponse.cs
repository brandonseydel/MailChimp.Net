using System.Collections.Generic;
using MailChimp.Net.Models;
using Newtonsoft.Json;

namespace MailChimp.Net.Core
{
    public class AuthorizedAppCreatedResponse
    {

        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

        [JsonProperty("viewer_token")]
        public string ViewerToken { get; set; }
    }
}