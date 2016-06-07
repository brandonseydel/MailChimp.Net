using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace MailChimp.Net.Models
{

    public class Options
    {
        public Options()
        {
            this.Choices = new HashSet<string>();
        }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("default_country")]
        public int DefaultCountry { get; set; }

        [JsonProperty("phone_format")]
        public string PhoneFormat { get; set; }

        [JsonProperty("date_format")]
        public string DateFormat { get; set; }

        [JsonProperty("choices")]
        public IEnumerable<string> Choices { get; set; }
    }
}
