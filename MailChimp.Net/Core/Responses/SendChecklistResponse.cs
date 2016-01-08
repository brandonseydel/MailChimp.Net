using System.Collections.Generic;
using MailChimp.Net.Logic;
using MailChimp.Net.Models;
using Newtonsoft.Json;

namespace MailChimp.Net.Core
{
    public class SendChecklistResponse
    {

        [JsonProperty("is_ready")]
        public bool IsReady { get; set; }

        [JsonProperty("items")]
        public IEnumerable<CheckList> CheckLists { get; set; }

        [JsonProperty("_links")]
        public IEnumerable<Link> Links { get; set; }
    }
}
