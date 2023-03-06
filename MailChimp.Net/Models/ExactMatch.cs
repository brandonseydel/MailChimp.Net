using Newtonsoft.Json;
using System.Collections.Generic;

namespace MailChimp.Net.Models;

public class ExactMatch
{
    public ExactMatch()
    {
        Members = new HashSet<Member>();
    }

    [JsonProperty("members")]
    public IEnumerable<Member> Members { get; set; }

    [JsonProperty("total_items")]
    public int TotalItems { get; set; }
}
