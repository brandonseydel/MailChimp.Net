using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailChimp.Net.Models
{
    public class ContentTemplate
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("sections")]
        public Dictionary<string, object> Sections { get; set; }
    }
}
