using System.Collections.Generic;
using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    public class Runtime
    {
        public Runtime()
        {
            Days = new HashSet<string>();
        }

        [JsonProperty("days")]
        public IEnumerable<string> Days { get; set; }

        [JsonProperty("hours")]
        public Hours Hours { get; set; }
    }
}