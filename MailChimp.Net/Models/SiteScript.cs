using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MailChimp.Net.Models;

public class SiteScript
{
    [JsonProperty("url")]
    public string Url { get; set; }

    [JsonProperty("fragment")]
    public string Fragment { get; set; }
}