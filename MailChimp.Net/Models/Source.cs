using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailChimp.Net.Models
{
    public class Source
    {
        [JsonProperty("user")]
        public bool User { get; set; }

        [JsonProperty("admin")]
        public bool Admin { get; set; }

        [JsonProperty("api")]
        public bool Api { get; set; }
    }
}
