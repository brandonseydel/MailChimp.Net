using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MailChimp.Net.Core.Requests
{
    public class ConnectedWebsiteRequest
    {
        [JsonProperty("domain")]
        public string domain { get; set; }

        [JsonProperty("foreign_id")]
        public string foreign_id { get; set; }
    }
}