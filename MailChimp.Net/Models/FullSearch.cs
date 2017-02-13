using Newtonsoft.Json;
using System.Collections.Generic;
public class FullSearch
{
    public FullSearch()
    {
        this.Members = new HashSet<Member>();
    }

    [JsonProperty("members")]
    public IEnumerable<Member> Members { get; set; }

    [JsonProperty("total_items")]
    public int TotalItems { get; set; }
}
