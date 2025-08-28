using Newtonsoft.Json;
using System.Collections.Generic;

namespace MailChimp.Net.Models;

public class FullSearch
{
    public FullSearch()
    {
        Members = new HashSet<Member>();
    }

    [JsonProperty("members")]
    public IEnumerable<Member> Members { get; set; }

    [JsonProperty("total_items")]
    public int TotalItems { get; set; }
}
