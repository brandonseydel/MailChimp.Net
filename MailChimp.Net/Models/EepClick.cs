using System.Collections.Generic;
using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    public class EepClick
    {
        public int Clicks { get; set; }

        [JsonProperty("first_click")]
        public string FirstClick { get; set; }

        [JsonProperty("last_click")]
        public string LastClick { get; set; }

        public IEnumerable<EepLocation> Locations { get; set; }
    }
}