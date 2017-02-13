using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailChimp.Net.Models
{
    public class Result
    {
        [JsonProperty("campaign")]
        public Campaign Campaign { get; set; }

        [JsonProperty("snippet")]
        public string Snippet { get; set; }
    }
}
