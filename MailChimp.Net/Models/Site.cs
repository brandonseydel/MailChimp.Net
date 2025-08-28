using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MailChimp.Net.Models;

public class Site
{
    [JsonProperty("foreign_id")]
    public string ForeignId { get; set; }

    [JsonProperty("store_id")]
    public string StoreId { get; set; }

    [JsonProperty("platform")]
    public string Platform { get; set; }

    [JsonProperty("domain")]
    public string Domain { get; set; }

    [JsonProperty("site_script")]
    public SiteScript SiteScript { get; set; }

    [JsonProperty("created_at")]
    public DateTime CreatedAt { get; set; }

    [JsonProperty("updated_at")]
    public DateTime UpdatedAt { get; set; }

    [JsonProperty("_links")]
    public List<Link> Links { get; set; }
}
