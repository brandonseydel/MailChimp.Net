using System.Collections.Generic;
using MailChimp.Net.Models;
using Newtonsoft.Json;

namespace MailChimp.Net.Core
{
    public class TemplateResponse : BaseResponse
    {
        public TemplateResponse()
        {
            Templates = new HashSet<Template>();
        }

        [JsonProperty("templates")]
        public IEnumerable<Template> Templates { get; set; }
    }
}