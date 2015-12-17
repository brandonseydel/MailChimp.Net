using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailChimp.Net.Interfaces;
using MailChimp.Net.Models;
using Newtonsoft.Json;

namespace MailChimp.Net.Core
{
    public class ContentRequest
    {
        [JsonProperty("plain_text")]
        public string PlainText { get; set; }

        [JsonProperty("html")]
        public string Html { get; set; }

        [JsonProperty("_links")]
        public Link[] Links { get; set; }

        public Template Template { get; set; }
        public Archive Archive { get; set; }

    }
}
